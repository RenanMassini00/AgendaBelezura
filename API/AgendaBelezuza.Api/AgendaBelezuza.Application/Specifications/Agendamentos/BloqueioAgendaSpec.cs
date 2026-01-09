using AgendaBelezuza.Application.Repositories;
using AgendaBelezuza.Domain.Exceptions;

namespace AgendaBelezuza.Application.Specifications.Agendamentos
{
    public class BloqueioAgendaSpec : IAgendamentoSpecification
    {
        private readonly IBloqueioAgendaRepository _repo;

        public BloqueioAgendaSpec(IBloqueioAgendaRepository repo)
        {
            _repo = repo;
        }

        public async Task ValidateAsync(Domain.Entities.Agendamento ag)
        {
            var bloqueios = await _repo.ListarPorProfissionalAsync(
                ag.ProfissionalId, ag.DataInicio, ag.DataFim);

            if (bloqueios.Any())
                throw new DomainException("O horário está bloqueado.");
        }
    }
}
