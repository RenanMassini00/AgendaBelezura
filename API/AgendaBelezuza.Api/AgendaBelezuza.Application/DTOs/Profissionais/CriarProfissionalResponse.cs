using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaBelezuza.Application.DTOs.Profissionais
{
    public class CriarProfissionalResponse
    {
        public int Id { get; set; }
        public string NomePublico { get; set; } = null!;
    }
}
