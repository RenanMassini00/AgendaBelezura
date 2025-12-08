namespace AgendaBelezuza.Domain.Entities
{
    public class HorarioFuncionamento
    {
        public int Id { get; private set; }
        public int ProfissionalId { get; private set; }
        public Profissional Profissional { get; private set; }

        public int DiaSemana { get; private set; }
        public TimeSpan HoraInicio { get; private set; }
        public TimeSpan HoraFim { get; private set; }

        public bool Ativo { get; private set; }
        public DateTime CriadoEm { get; private set; }
        public DateTime? AtualizadoEm { get; private set; }

        protected HorarioFuncionamento() { }

        public HorarioFuncionamento(int profissionalId, int diaSemana, TimeSpan inicio, TimeSpan fim)
        {
            ProfissionalId = profissionalId;
            DiaSemana = diaSemana;
            HoraInicio = inicio;
            HoraFim = fim;

            Ativo = true;
            CriadoEm = DateTime.UtcNow;
        }
    }
}
