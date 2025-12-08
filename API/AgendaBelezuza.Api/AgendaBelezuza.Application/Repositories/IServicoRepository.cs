using AgendaBelezuza.Domain.Entities;


namespace AgendaBelezuza.Application.Repositories
{
    public interface IServicoRepository
    {
        Task<Servico?> ObterPorIdAsync(int id);
        Task<IEnumerable<Servico>> ListarPorProfissionalAsync(int profissionalId);
        Task AdicionarAsync(Servico servico);
        Task AtualizarAsync(Servico servico);
    }
}
