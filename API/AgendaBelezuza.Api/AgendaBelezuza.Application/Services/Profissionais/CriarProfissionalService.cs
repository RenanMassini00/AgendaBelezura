using AgendaBelezuza.Application.DTOs.Profissionais;
using AgendaBelezuza.Application.Repositories;
using AgendaBelezuza.Domain.Entities;
using AgendaBelezuza.Domain.Exceptions;

namespace AgendaBelezuza.Application.Services.Profissionais
{
    public class CriarProfissionalService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IProfissionalRepository _profissionalRepository;

        public CriarProfissionalService(
            IUsuarioRepository usuarioRepository,
            IProfissionalRepository profissionalRepository)
        {
            _usuarioRepository = usuarioRepository;
            _profissionalRepository = profissionalRepository;
        }

        public async Task<CriarProfissionalResponse> ExecuteAsync(CriarProfissionalRequest request)
        {
            // Verifica se possui algum bonito
            var usuario = await _usuarioRepository.ObterPorIdAsync(request.UsuarioId);
            if (usuario is null)
                throw new DomainException("Usuário não encontrado.");

            var profissional = new Profissional(
                usuarioId: request.UsuarioId,
                nomePublico: request.NomePublico
            );

            await _profissionalRepository.AdicionarAsync(profissional);

            return new CriarProfissionalResponse
            {
                Id = profissional.Id,
                NomePublico = profissional.NomePublico
            };
        }
    }
}
