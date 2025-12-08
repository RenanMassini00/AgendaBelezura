using AgendaBelezuza.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaBelezuza.Application.Repositories
{
    public interface IAgendamentoRepository
    {
        Task<Agendamento?> ObterPorIdAsync(int id);
        Task<IEnumerable<Agendamento>> ListarPorProfissionalAsync(int profissionalId, DateTime dataInicio, DateTime dataFim);
        Task<IEnumerable<Agendamento>> ListarPorClienteAsync(int clienteId);
        Task AdicionarAsync(Agendamento agendamento);
        Task AtualizarAsync(Agendamento agendamento);

        Task<bool> ExisteChoqueHorarioAsync(int profissionalId, DateTime inicio, DateTime fim);
    }
}
