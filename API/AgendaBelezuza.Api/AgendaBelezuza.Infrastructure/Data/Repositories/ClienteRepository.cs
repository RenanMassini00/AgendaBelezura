using AgendaBelezuza.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AgendaBelezuza.Infrastructure.Data.Repositories
{
    public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
    {
        private readonly AgendaDbContext _context;

        public ClienteRepository(AgendaDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Cliente?> ObterPorIdAsync(int id)
            => await _context.Clientes.FindAsync(id);

        public async Task<IEnumerable<Cliente>> ListarAsync()
            => await _context.Clientes.ToListAsync();
    }
}
