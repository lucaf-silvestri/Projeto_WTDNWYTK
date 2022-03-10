using Projeto_WTDNWYTK.Contexts;
using Projeto_WTDNWYTK.Domains;
using Projeto_WTDNWYTK.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Projeto_WTDNWYTK.Repositories
{
    public class TipoRepository : ITipoRepository
    {
        WTDNWYTKContext ctx = new WTDNWYTKContext();

        public void Atualizar(int idTipo, Tipo TipoAtualizada)
        {
            Tipo TipoBuscada = Listarid(idTipo);

            if (TipoBuscada != null)
            {
                TipoBuscada.NomeTipo = TipoAtualizada.NomeTipo;
            }

            ctx.Tipos.Update(TipoBuscada);

            ctx.SaveChanges();
        }

        public void Cadastrar(Tipo novaTipo)
        {
            ctx.Tipos.Add(novaTipo);

            ctx.SaveChanges();
        }

        public void Deletar(int idTipo)
        {
            Tipo TipoBuscada = Listarid(idTipo);

            ctx.Tipos.Remove(TipoBuscada);

            ctx.SaveChanges();
        }

        public List<Tipo> Listar()
        {
            return ctx.Tipos.ToList();
        }

        public Tipo Listarid(int id)
        {
            return ctx.Tipos.FirstOrDefault(c => c.IdTipo == id);
        }
    }
}
