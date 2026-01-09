using AgendaBelezuza.Application.Repositories;
using AgendaBelezuza.Domain.Exceptions;

namespace AgendaBelezuza.Application.Specifications.Agendamentos
{
    public class HorarioFuncionamentoSpec : IAgendamentoSpecification
    {
        private readonly IHorarioFuncionamentoRepository _repo;

        public HorarioFuncionamentoSpec(IHorarioFuncionamentoRepository repo)
        {
            _repo = repo;
        }

        public async Task ValidateAsync(Domain.Entities.Agendamento ag)
        {
            var horarios = await _repo.ListarPorProfissionalAsync(ag.ProfissionalId);

            var dia = (int)ag.DataInicio.DayOfWeek;

            var funcionamento = horarios.FirstOrDefault(h => h.DiaSemana == dia);

            if (funcionamento == null)
                throw new DomainException("O profissional não atende neste dia.");

            if (ag.DataInicio.TimeOfDay < funcionamento.HoraInicio ||
                ag.DataFim.TimeOfDay > funcionamento.HoraFim)
            {
                throw new DomainException("O horário está fora do período de atendimento.");
            }
        }
    }
}
