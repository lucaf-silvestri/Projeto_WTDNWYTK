using System;
using System.Collections.Generic;

#nullable disable

namespace Projeto_WTDNWYTK.Domains
{
    public partial class RegiaoHistorium
    {
        public short IdRegiaoHistoria { get; set; }
        public short IdHistoria { get; set; }
        public short IdRegiao { get; set; }

        public virtual Historium IdHistoriaNavigation { get; set; }
        public virtual Regiao IdRegiaoNavigation { get; set; }
    }
}
