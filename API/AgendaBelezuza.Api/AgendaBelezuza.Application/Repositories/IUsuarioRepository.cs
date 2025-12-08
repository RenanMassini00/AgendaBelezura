using AgendaBelezuza.Domain.Entities;


namespace AgendaBelezuza.Application.Repositories
{
    public interface IUsuarioRepository
    {
        Task<Usuario?> ObterPorIdAsync(int id);
        Task<Usuario?> ObterPorEmailAsync(string email);
        Task AdicionarAsync(Usuario usuario);
        Task AtualizarAsync(Usuario usuario);
    }
}
