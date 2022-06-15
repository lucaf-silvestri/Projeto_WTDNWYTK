using System;
using System.Collections.Generic;

#nullable disable

namespace Projeto_WTDNWYTK.Domains
{
    public partial class TipoHistorium
    {
        public short IdTipoHistoria { get; set; }
        public short IdHistoria { get; set; }
        public short IdTipo { get; set; }

        public virtual Historium IdHistoriaNavigation { get; set; }
        public virtual Tipo IdTipoNavigation { get; set; }
    }
}
