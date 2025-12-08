using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaBelezuza.Domain.Entities
{
    public class Perfil
    {
        public int Id { get; private set; }
        public string Nome { get; private set; } = null!;

        protected Perfil() { }

        public Perfil(string nome)
        {
            Nome = nome;
        }
    }
}
