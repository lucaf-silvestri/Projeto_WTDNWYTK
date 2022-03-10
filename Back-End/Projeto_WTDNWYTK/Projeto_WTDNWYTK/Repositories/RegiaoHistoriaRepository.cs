using Projeto_WTDNWYTK.Contexts;
using Projeto_WTDNWYTK.Domains;
using Projeto_WTDNWYTK.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Projeto_WTDNWYTK.Repositories
{
    public class RegiaoHistoriaRepository : IRegiaoHistoriaRepository
    {
        WTDNWYTKContext ctx = new WTDNWYTKContext();

        public void Cadastrar(RegiaoHistorium novaRegiaoHistoria)
        {
            ctx.RegiaoHistoria.Add(novaRegiaoHistoria);

            ctx.SaveChanges();
        }

        public List<RegiaoHistorium> Listar()
        {
            return ctx.RegiaoHistoria
                .Select(c => new RegiaoHistorium
                {
                    IdRegiao = c.IdRegiao,
                    IdHistoria = c.IdHistoria,

                    IdRegiaoNavigation = new Regiao
                    {
                        NomeRegiao = c.IdRegiaoNavigation.NomeRegiao,
                    },

                    IdHistoriaNavigation = new Historium
                    {
                        IdUsuario = c.IdHistoriaNavigation.IdUsuario,
                        Titulo = c.IdHistoriaNavigation.Titulo,
                        Texto = c.IdHistoriaNavigation.Texto,
                        Imagem1 = c.IdHistoriaNavigation.Imagem1,
                        Imagem2 = c.IdHistoriaNavigation.Imagem2,
                    }
                }).ToList();
        }
    }
}
