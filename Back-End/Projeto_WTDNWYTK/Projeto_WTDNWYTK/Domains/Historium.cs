using System;
using System.Collections.Generic;

#nullable disable

namespace Projeto_WTDNWYTK.Domains
{
    public partial class Historium
    {
        public short IdHistoria { get; set; }
        public short IdUsuario { get; set; }
        public string Titulo { get; set; }
        public string Texto { get; set; }
        public string Imagem1 { get; set; }
        public string Imagem2 { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
