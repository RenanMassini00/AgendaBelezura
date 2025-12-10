using AgendaBelezuza.Application.Interfaces.Repositories;
using AgendaBelezuza.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AgendaBelezuza.Infrastructure.Data.Repositories
{
    public class ServicoRepository : BaseRepository<Servico>, IServicoRepository
    {
        private readonly AgendaDbContext _context;

        public ServicoRepository(AgendaDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Servico?> ObterPorIdAsync(int id)
            => await _context.Servicos.FindAsync(id);

        public async Task<IEnumerable<Servico>> ListarPorProfissionalAsync(int profissionalId)
            => await _context.Servicos
                    .Where(s => s.ProfissionalId == profissionalId)
                    .ToListAsync();
    }
}
