using AgendaBelezuza.Domain.Entities;


namespace AgendaBelezuza.Application.Repositories
{
    public interface IClienteRepository
    {
        Task<Cliente?> ObterPorIdAsync(int id);
        Task<IEnumerable<Cliente>> ListarAsync();
        Task AdicionarAsync(Cliente cliente);
        Task AtualizarAsync(Cliente cliente);
    }
}
