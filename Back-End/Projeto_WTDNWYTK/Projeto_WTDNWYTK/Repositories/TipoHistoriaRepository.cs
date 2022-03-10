using Projeto_WTDNWYTK.Contexts;
using Projeto_WTDNWYTK.Domains;
using Projeto_WTDNWYTK.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Projeto_WTDNWYTK.Repositories
{
    public class TipoHistoriaRepository : ITipoHistoriaRepository
    {
        WTDNWYTKContext ctx = new WTDNWYTKContext();

        public void Cadastrar(TipoHistorium novaTipoHistoria)
        {
            ctx.TipoHistoria.Add(novaTipoHistoria);

            ctx.SaveChanges();
        }

        public List<TipoHistorium> Listar()
        {
            return ctx.TipoHistoria
                .Select(c => new TipoHistorium
                {
                    IdTipo = c.IdTipo,
                    IdHistoria = c.IdHistoria,

                    IdTipoNavigation = new Tipo
                    {
                        NomeTipo = c.IdTipoNavigation.NomeTipo,
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
