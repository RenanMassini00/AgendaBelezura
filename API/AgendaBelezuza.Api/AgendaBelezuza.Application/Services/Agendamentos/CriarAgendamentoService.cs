using AgendaBelezuza.Application.DTOs.Agendamentos;
using AgendaBelezuza.Application.Factories;
using AgendaBelezuza.Application.Repositories;
using AgendaBelezuza.Application.Specifications.Agendamentos;
using AgendaBelezuza.Domain.Exceptions;

namespace AgendaBelezuza.Application.Services.Agendamentos
{
    public class CriarAgendamentoService
    {
        private readonly IClienteRepository _clienteRepo;
        private readonly IProfissionalRepository _profRepo;
        private readonly IServicoRepository _servicoRepo;
        private readonly IAgendamentoRepository _agRepo;

        private readonly IEnumerable<IAgendamentoSpecification> _specs;

        public CriarAgendamentoService(
            IClienteRepository clienteRepo,
            IProfissionalRepository profRepo,
            IServicoRepository servicoRepo,
            IBloqueioAgendaRepository bloqueioRepo,
            IHorarioFuncionamentoRepository horarioRepo,
            IAgendamentoRepository agRepo)
        {
            _clienteRepo = clienteRepo;
            _profRepo = profRepo;
            _servicoRepo = servicoRepo;
            _agRepo = agRepo;

            // Registra todas as validações
            _specs = new List<IAgendamentoSpecification>()
        {
            new ChoqueHorarioSpec(agRepo),
            new BloqueioAgendaSpec(bloqueioRepo),
            new HorarioFuncionamentoSpec(horarioRepo)
        };
        }

        public async Task<CriarAgendamentoResponse> ExecuteAsync(CriarAgendamentoRequest req)
        {
            var cliente = await _clienteRepo.ObterPorIdAsync(req.ClienteId)
                ?? throw new DomainException("Cliente não encontrado.");

            var profissional = await _profRepo.ObterPorIdAsync(req.ProfissionalId)
                ?? throw new DomainException("Profissional não encontrado.");

            var servico = await _servicoRepo.ObterPorIdAsync(req.ServicoId)
                ?? throw new DomainException("Serviço não encontrado.");

            // Criar entidade via Factory
            var agendamento = AgendamentoFactory.Criar(
                req.ClienteId,
                req.ProfissionalId,
                req.ServicoId,
                req.DataInicio,
                servico.DuracaoMinutos
            );

            // Aplicar todas as regras (Specification Pattern)
            foreach (var spec in _specs)
                await spec.ValidateAsync(agendamento);

            // Persistir
            await _agRepo.AddAsync(agendamento);

            return new CriarAgendamentoResponse
            {
                Id = agendamento.Id,
                DataInicio = agendamento.DataInicio,
                DataFim = agendamento.DataFim,
                Status = agendamento.Status
            };
        }
    }
}
