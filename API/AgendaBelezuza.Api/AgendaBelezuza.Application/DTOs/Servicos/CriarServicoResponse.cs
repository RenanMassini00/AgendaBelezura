using AgendaBelezuza.Application.DTOs.Servicos;
using AgendaBelezuza.Application.Interfaces.Repositories;
using AgendaBelezuza.Domain.Entities;
using AgendaBelezuza.Domain.Exceptions;

namespace AgendaBelezuza.Application.DTOs.Servicos
{
    public class CriarServicoResponse
    {
        public int Id { get; set; }
        public string Nome { get; set; } = null!;
    }
}
