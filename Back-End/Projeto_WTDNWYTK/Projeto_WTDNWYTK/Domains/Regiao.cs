using System;
using System.Collections.Generic;

#nullable disable

namespace Projeto_WTDNWYTK.Domains
{
    public partial class Regiao
    {
        public Regiao()
        {
            RegiaoHistoria = new HashSet<RegiaoHistorium>();
        }

        public short IdRegiao { get; set; }
        public string NomeRegiao { get; set; }

        public virtual ICollection<RegiaoHistorium> RegiaoHistoria { get; set; }
    }
}
