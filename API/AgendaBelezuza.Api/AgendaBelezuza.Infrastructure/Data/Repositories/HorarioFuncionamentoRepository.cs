using AgendaBelezuza.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaBelezuza.Infrastructure.Data.Repositories
{
    public class HorarioFuncionamentoRepository : BaseRepository<HorarioFuncionamento>, IHorarioFuncionamentoRepository
    {
        private readonly AgendaDbContext _context;

        public HorarioFuncionamentoRepository(AgendaDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<HorarioFuncionamento>> ListarPorProfissionalAsync(int profissionalId)
            => await _context.HorariosFuncionamento
                .Where(h => h.ProfissionalId == profissionalId)
                .ToListAsync();
    }
}
