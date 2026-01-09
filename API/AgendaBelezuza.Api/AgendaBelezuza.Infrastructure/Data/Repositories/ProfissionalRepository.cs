using AgendaBelezuza.Application.Repositories;
using AgendaBelezuza.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AgendaBelezuza.Infrastructure.Data.Repositories
{
    public class ProfissionalRepository : BaseRepository<Profissional>, IProfissionalRepository
    {
        private readonly AgendaDbContext _context;

        public ProfissionalRepository(AgendaDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Profissional?> ObterPorIdAsync(int id)
            => await _context.Profissionais
                .Include(p => p.Servicos)
                .Include(p => p.HorariosFuncionamento)
                .Include(p => p.Configuracoes)
                .FirstOrDefaultAsync(p => p.Id == id);

        public async Task<IEnumerable<Profissional>> ListarAsync()
            => await _context.Profissionais.ToListAsync();

        public async Task<bool> ExisteUsuarioVinculadoAsync(int usuarioId)
            => await _context.Profissionais.AnyAsync(p => p.UsuarioId == usuarioId);
        public async Task AdicionarAsync(Profissional profissional)
        => await AddAsync(profissional);

        public async Task AtualizarAsync(Profissional profissional)
            => await UpdateAsync(profissional);
    }
}
