using AgendaBelezuza.Application.Repositories;
using AgendaBelezuza.Domain.Exceptions;

namespace AgendaBelezuza.Application.Specifications.Agendamentos
{

    public class ChoqueHorarioSpec : IAgendamentoSpecification
    {
        private readonly IAgendamentoRepository _repo;

        public ChoqueHorarioSpec(IAgendamentoRepository repo)
        {
            _repo = repo;
        }

        public async Task ValidateAsync(Domain.Entities.Agendamento ag)
        {
            var existeChoque = await _repo.ExisteChoqueHorarioAsync(
                ag.ProfissionalId, ag.DataInicio, ag.DataFim);

            if (existeChoque)
                throw new DomainException("O horário já está ocupado.");
        }
    }
}
