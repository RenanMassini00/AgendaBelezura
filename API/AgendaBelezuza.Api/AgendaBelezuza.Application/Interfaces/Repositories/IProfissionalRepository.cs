using AgendaBelezuza.Domain.Entities;


namespace AgendaBelezuza.Application.Repositories
{
    public interface IProfissionalRepository
    {
        Task<Profissional?> ObterPorIdAsync(int id);
        Task<IEnumerable<Profissional>> ListarAsync();
        Task AdicionarAsync(Profissional profissional);
        Task AtualizarAsync(Profissional profissional);

        Task<bool> ExisteUsuarioVinculadoAsync(int usuarioId);
    }
}
