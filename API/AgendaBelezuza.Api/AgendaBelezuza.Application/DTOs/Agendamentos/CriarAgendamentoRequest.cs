using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaBelezuza.Application.DTOs.Agendamentos
{
    public class CriarAgendamentoRequest
    {
        public int ClienteId { get; set; }
        public int ProfissionalId { get; set; }
        public int ServicoId { get; set; }
        public DateTime DataInicio { get; set; }
    }
}
