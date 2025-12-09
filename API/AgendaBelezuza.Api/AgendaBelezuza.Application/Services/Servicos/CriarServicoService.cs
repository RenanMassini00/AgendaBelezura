using AgendaBelezuza.Application.DTOs.Servicos;
using AgendaBelezuza.Application.Repositories;
using AgendaBelezuza.Domain.Entities;
using AgendaBelezuza.Domain.Exceptions;


namespace AgendaBelezuza.Application.Services.Servicos
{
    public class CriarServicoService
    {
        private readonly IProfissionalRepository _profRepository;
        private readonly IServicoRepository _servicoRepository;

        public CriarServicoService(
            IProfissionalRepository profRepository,
            IServicoRepository servicoRepository)
        {
            _profRepository = profRepository;
            _servicoRepository = servicoRepository;
        }

        public async Task<CriarServicoResponse> ExecuteAsync(CriarServicoRequest request)
        {
            var prof = await _profRepository.ObterPorIdAsync(request.ProfissionalId)
                ?? throw new DomainException("Profissional não encontrado.");

            var servico = new Servico(
                profissionalId: request.ProfissionalId,
                nome: request.Nome,
                duracao: request.DuracaoMinutos,
                preco: request.Preco
            );

            await _servicoRepository.AdicionarAsync(servico);

            return new CriarServicoResponse
            {
                Id = servico.Id,
                Nome = servico.Nome
            };
        }
    }
}
