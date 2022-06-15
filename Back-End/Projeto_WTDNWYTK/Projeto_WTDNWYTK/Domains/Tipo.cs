using System;
using System.Collections.Generic;

#nullable disable

namespace Projeto_WTDNWYTK.Domains
{
    public partial class Tipo
    {
        public Tipo()
        {
            TipoHistoria = new HashSet<TipoHistorium>();
        }

        public short IdTipo { get; set; }
        public string NomeTipo { get; set; }

        public virtual ICollection<TipoHistorium> TipoHistoria { get; set; }
    }
}
