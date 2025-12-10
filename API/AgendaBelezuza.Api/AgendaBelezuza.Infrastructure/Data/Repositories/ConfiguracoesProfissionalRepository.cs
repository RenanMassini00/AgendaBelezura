using AgendaBelezuza.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AgendaBelezuza.Infrastructure.Data.Repositories
{
    public class ConfiguracoesProfissionalRepository : BaseRepository<ConfiguracoesProfissional>, IConfiguracoesProfissionalRepository
    {
        private readonly AgendaDbContext _context;

        public ConfiguracoesProfissionalRepository(AgendaDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<ConfiguracoesProfissional?> ObterPorProfissionalIdAsync(int profissionalId)
            => await _context.ConfiguracoesProfissional
                .FirstOrDefaultAsync(c => c.ProfissionalId == profissionalId);
    }
}
