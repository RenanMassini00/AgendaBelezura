using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaBelezuza.Domain.Entities
{
    public class Cliente
    {
        public int Id { get; private set; }
        public string Nome { get; private set; } = null!;
        public string? Telefone { get; private set; }
        public string? Email { get; private set; }
        public string? Documento { get; private set; }

        public bool Ativo { get; private set; }

        public DateTime CriadoEm { get; private set; }
        public DateTime? AtualizadoEm { get; private set; }

        public ICollection<Agendamento> Agendamentos { get; private set; } = new List<Agendamento>();

        protected Cliente() { }

        public Cliente(string nome)
        {
            Nome = nome;
            Ativo = true;
            CriadoEm = DateTime.UtcNow;
        }
    }
}
