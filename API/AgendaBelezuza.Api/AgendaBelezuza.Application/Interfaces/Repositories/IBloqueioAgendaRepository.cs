using AgendaBelezuza.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaBelezuza.Application.Repositories
{
    public interface IBloqueioAgendaRepository
    {
        Task<IEnumerable<BloqueioAgenda>> ListarPorProfissionalAsync(int profissionalId, DateTime inicio, DateTime fim);
        Task AdicionarAsync(BloqueioAgenda bloqueio);
        Task AtualizarAsync(BloqueioAgenda bloqueio);
    }
}
