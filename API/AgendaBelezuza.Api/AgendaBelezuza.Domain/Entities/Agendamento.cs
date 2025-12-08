using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaBelezuza.Domain.Entities
{
    public class Agendamento
    {
        public int Id { get; private set; }

        public int ProfissionalId { get; private set; }
        public Profissional Profissional { get; private set; } = null!;

        public int ClienteId { get; private set; }
        public Cliente Cliente { get; private set; } = null!;

        public int ServicoId { get; private set; }
        public Servico Servico { get; private set; } = null!;

        public DateTime DataInicio { get; private set; }
        public DateTime DataFim { get; private set; }
        public string Status { get; private set; } = "MARCADO";

        public string? Observacoes { get; private set; }

        public DateTime CriadoEm { get; private set; }
        public DateTime? AtualizadoEm { get; private set; }

        protected Agendamento() { }

        public Agendamento(int profissionalId, int clienteId, int servicoId, DateTime inicio, DateTime fim)
        {
            ProfissionalId = profissionalId;
            ClienteId = clienteId;
            ServicoId = servicoId;
            DataInicio = inicio;
            DataFim = fim;

            CriadoEm = DateTime.UtcNow;
        }

        public void Cancelar()
        {
            Status = "CANCELADO";
            AtualizadoEm = DateTime.UtcNow;
        }
    }
}
