using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaBelezuza.Domain.Entities
{
    public class UsuarioPerfil
    {
        public int UsuarioId { get; private set; }
        public Usuario Usuario { get; private set; }

        public int PerfilId { get; private set; }
        public Perfil Perfil { get; private set; }

        protected UsuarioPerfil() { }

        public UsuarioPerfil(int usuarioId, int perfilId)
        {
            UsuarioId = usuarioId;
            PerfilId = perfilId;
        }
    }
}
