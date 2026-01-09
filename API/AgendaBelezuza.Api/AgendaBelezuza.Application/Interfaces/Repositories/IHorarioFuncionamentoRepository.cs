using AgendaBelezuza.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaBelezuza.Application.Repositories
{
    public interface IHorarioFuncionamentoRepository
    {
        Task<IEnumerable<HorarioFuncionamento>> ListarPorProfissionalAsync(int profissionalId);
        Task AdicionarAsync(HorarioFuncionamento horario);
        Task AtualizarAsync(HorarioFuncionamento horario);
    }
}
