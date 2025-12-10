using AgendaBelezuza.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AgendaBelezuza.Infrastructure.Data.Repositories
{
    public class BloqueioAgendaRepository : BaseRepository<BloqueioAgenda>, IBloqueioAgendaRepository
    {
        private readonly AgendaDbContext _context;

        public BloqueioAgendaRepository(AgendaDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<BloqueioAgenda>> ListarPorProfissionalAsync(int profissionalId, DateTime inicio, DateTime fim)
            => await _context.BloqueiosAgenda
                .Where(b => b.ProfissionalId == profissionalId &&
                            b.DataHoraInicio < fim &&
                            inicio < b.DataHoraFim &&
                            b.Ativo)
                .ToListAsync();
    }
}
