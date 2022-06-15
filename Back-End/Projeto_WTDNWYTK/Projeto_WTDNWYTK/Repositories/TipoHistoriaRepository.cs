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

        public void Atualizar(int idTipoHistoria, TipoHistorium TipoHistoriaAtualizada)
        {
            TipoHistorium TipoHistoriaBuscada = Listarid(idTipoHistoria);

            if (TipoHistoriaBuscada != null)
            {
                TipoHistoriaBuscada.IdTipo = TipoHistoriaAtualizada.IdTipo;
                TipoHistoriaBuscada.IdHistoria = TipoHistoriaAtualizada.IdHistoria;
            }

            ctx.TipoHistoria.Update(TipoHistoriaBuscada);

            ctx.SaveChanges();
        }

        public void Cadastrar(TipoHistorium novaTipoHistoria)
        {
            ctx.TipoHistoria.Add(novaTipoHistoria);

            ctx.SaveChanges();
        }

        public void Deletar(int idTipoHistoria)
        {
            TipoHistorium TipoHistoriaBuscada = Listarid(idTipoHistoria);

            ctx.TipoHistoria.Remove(TipoHistoriaBuscada);

            ctx.SaveChanges();
        }

        public List<TipoHistorium> Listar()
        {
            return ctx.TipoHistoria.ToList();
        }

        public TipoHistorium Listarid(int id)
        {
            return ctx.TipoHistoria.FirstOrDefault(c => c.IdTipoHistoria == id);
        }
    }
}
