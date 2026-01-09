using AgendaBelezuza.Application.Repositories;
using AgendaBelezuza.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AgendaBelezuza.Infrastructure.Data.Repositories
{
    public class UsuarioRepository
    : BaseRepository<Usuario>, IUsuarioRepository
    {
        private readonly AgendaDbContext _context;

        public UsuarioRepository(AgendaDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Usuario?> ObterPorIdAsync(int id)
            => await _context.Usuarios.FindAsync(id);

        public async Task<Usuario?> ObterPorEmailAsync(string email)
            => await _context.Usuarios.FirstOrDefaultAsync(u => u.Email == email);

        public async Task AdicionarAsync(Usuario usuario)
            => await AddAsync(usuario);

        public async Task AtualizarAsync(Usuario usuario)
            => await UpdateAsync(usuario);
    }
}
