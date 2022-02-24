using System;
using System.Collections.Generic;

#nullable disable

namespace Projeto_WTDNWYTK.Domains
{
    public partial class Usuario
    {
        public Usuario()
        {
            Historia = new HashSet<Historium>();
        }

        public short IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public virtual ICollection<Historium> Historia { get; set; }
    }
}
