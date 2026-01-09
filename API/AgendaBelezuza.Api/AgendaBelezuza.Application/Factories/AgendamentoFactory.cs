using AgendaBelezuza.Domain.Entities;

namespace AgendaBelezuza.Application.Factories
{
    public static class AgendamentoFactory
    {
        public static Agendamento Criar(
            int clienteId,
            int profissionalId,
            int servicoId,
            DateTime inicio,
            int duracaoMinutos)
        {
            var fim = inicio.AddMinutes(duracaoMinutos);

            return new Agendamento(
                profissionalId,
                clienteId,
                servicoId,
                inicio,
                fim
            );
        }
    }
}
