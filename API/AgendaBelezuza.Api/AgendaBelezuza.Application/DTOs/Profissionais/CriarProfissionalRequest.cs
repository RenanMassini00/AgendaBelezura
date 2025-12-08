using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaBelezuza.Application.DTOs.Profissionais
{
    public class CriarProfissionalRequest
    {
        public int UsuarioId { get; set; }
        public string NomePublico { get; set; } = null!;
    }
}
