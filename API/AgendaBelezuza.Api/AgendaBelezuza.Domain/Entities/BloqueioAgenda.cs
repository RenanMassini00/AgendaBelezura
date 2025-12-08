using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaBelezuza.Domain.Entities
{
    public class BloqueioAgenda
    {
        public int Id { get; private set; }
        public int ProfissionalId { get; private set; }
        public Profissional Profissional { get; private set; }

        public DateTime DataHoraInicio { get; private set; }
        public DateTime DataHoraFim { get; private set; }
        public string? Motivo { get; private set; }

        public bool Ativo { get; private set; }
        public DateTime CriadoEm { get; private set; }
        public DateTime? AtualizadoEm { get; private set; }

        protected BloqueioAgenda() { }

        public BloqueioAgenda(int profissionalId, DateTime inicio, DateTime fim, string? motivo)
        {
            ProfissionalId = profissionalId;
            DataHoraInicio = inicio;
            DataHoraFim = fim;
            Motivo = motivo;
            Ativo = true;

            CriadoEm = DateTime.UtcNow;
        }
    }
}
