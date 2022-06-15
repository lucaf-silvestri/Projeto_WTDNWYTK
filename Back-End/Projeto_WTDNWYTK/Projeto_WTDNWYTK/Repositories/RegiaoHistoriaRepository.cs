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

        public void Atualizar(int idRegiaoHistoria, RegiaoHistorium RegiaoHistoriaAtualizada)
        {
            RegiaoHistorium RegiaoHistoriaBuscada = Listarid(idRegiaoHistoria);

            if (RegiaoHistoriaBuscada != null)
            {
                RegiaoHistoriaBuscada.IdRegiao = RegiaoHistoriaAtualizada.IdRegiao;
                RegiaoHistoriaBuscada.IdHistoria = RegiaoHistoriaAtualizada.IdHistoria;
            }

            ctx.RegiaoHistoria.Update(RegiaoHistoriaBuscada);

            ctx.SaveChanges();
        }

        public void Cadastrar(RegiaoHistorium novaRegiaoHistoria)
        {
            ctx.RegiaoHistoria.Add(novaRegiaoHistoria);

            ctx.SaveChanges();
        }

        public void Deletar(int idRegiaoHistoria)
        {
            RegiaoHistorium RegiaoHistoriaBuscada = Listarid(idRegiaoHistoria);

            ctx.RegiaoHistoria.Remove(RegiaoHistoriaBuscada);

            ctx.SaveChanges();
        }

        public List<RegiaoHistorium> Listar()
        {
            return ctx.RegiaoHistoria.ToList();
        }

        public RegiaoHistorium Listarid(int id)
        {
            return ctx.RegiaoHistoria.FirstOrDefault(c => c.IdRegiaoHistoria == id);
        }
    }
}
