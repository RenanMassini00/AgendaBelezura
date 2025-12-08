using AgendaBelezuza.Application.DTOs.Usuarios;
using AgendaBelezuza.Application.Interfaces.Repositories;
using AgendaBelezuza.Application.Repositories;
using AgendaBelezuza.Domain.Entities;
using AgendaBelezuza.Domain.Exceptions;

namespace AgendaBelezuza.Application.Services.Usuarios
{
    public class CriarUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public CriarUsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task<CriarUsuarioResponse> ExecuteAsync(CriarUsuarioRequest request)
        {
            // 1. Validar se email já existe
            var existente = await _usuarioRepository.ObterPorEmailAsync(request.Email);
            if (existente is not null)
                throw new DomainException("E-mail já cadastrado.");

            // 2. Criar entidade Usuario
            var novoUsuario = new Usuario(
                nome: request.Nome,
                email: request.Email,
                senhaHash: BCrypt.Net.BCrypt.HashPassword(request.Senha)
            );

            // 3. Persistir
            await _usuarioRepository.AdicionarAsync(novoUsuario);

            // 4. Retornar DTO de saída
            return new CriarUsuarioResponse
            {
                Id = novoUsuario.Id,
                Nome = novoUsuario.Nome,
                Email = novoUsuario.Email
            };
        }
    }
}
