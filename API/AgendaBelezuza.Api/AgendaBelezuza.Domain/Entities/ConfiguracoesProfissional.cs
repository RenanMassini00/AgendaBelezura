namespace AgendaBelezuza.Domain.Entities
{
    public class ConfiguracoesProfissional
    {
        public int Id { get; private set; }
        public int ProfissionalId { get; private set; }
        public Profissional Profissional { get; private set; }

        public int IntervaloSlotsMinutos { get; private set; }
        public int AntecedenciaMinimaHoras { get; private set; }
        public int CancelamentoMinimoHoras { get; private set; }
        public bool PermiteAgendamentoOnline { get; private set; }

        public DateTime CriadoEm { get; private set; }
        public DateTime? AtualizadoEm { get; private set; }

        protected ConfiguracoesProfissional() { }

        public ConfiguracoesProfissional(
            int profissionalId,
            int intervaloSlotsMinutos,
            int antecedenciaMinima,
            int cancelamentoMinimo,
            bool permiteOnline)
        {
            ProfissionalId = profissionalId;
            IntervaloSlotsMinutos = intervaloSlotsMinutos;
            AntecedenciaMinimaHoras = antecedenciaMinima;
            CancelamentoMinimoHoras = cancelamentoMinimo;
            PermiteAgendamentoOnline = permiteOnline;

            CriadoEm = DateTime.UtcNow;
        }
    }
}
