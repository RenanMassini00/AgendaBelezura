using AgendaBelezuza.Application.Repositories;
using AgendaBelezuza.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace AgendaBelezuza.Infrastructure.Data.Repositories
{
    public class AgendamentoRepository : BaseRepository<Agendamento>, IAgendamentoRepository
    {
        private readonly AgendaDbContext _context;

        public AgendamentoRepository(AgendaDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Agendamento?> ObterPorIdAsync(int id)
            => await _context.Agendamentos.FindAsync(id);

        public async Task<IEnumerable<Agendamento>> ListarPorProfissionalAsync(int profissionalId, DateTime inicio, DateTime fim)
            => await _context.Agendamentos
                .Where(a => a.ProfissionalId == profissionalId &&
                            a.DataInicio >= inicio &&
                            a.DataFim <= fim)
                .ToListAsync();

        public async Task<IEnumerable<Agendamento>> ListarPorClienteAsync(int clienteId)
            => await _context.Agendamentos
                .Where(a => a.ClienteId == clienteId)
                .ToListAsync();

        public async Task<bool> ExisteChoqueHorarioAsync(int profissionalId, DateTime inicio, DateTime fim)
            => await _context.Agendamentos.AnyAsync(a =>
                   a.ProfissionalId == profissionalId &&
                   a.DataInicio < fim &&
                   inicio < a.DataFim &&
                   a.Status == "MARCADO"
               );
        public async Task AdicionarAsync(Agendamento agendamento)
        => await AddAsync(agendamento);

        public async Task AtualizarAsync(Agendamento agendamento)
            => await UpdateAsync(agendamento);
    }
}
