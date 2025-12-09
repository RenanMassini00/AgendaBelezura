using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaBelezuza.Application.DTOs.Servicos
{
    public class CriarServicoRequest
    {
        public int ProfissionalId { get; set; }
        public string Nome { get; set; } = null!;
        public string? Descricao { get; set; }
        public int DuracaoMinutos { get; set; }
        public decimal Preco { get; set; }
    }
}
