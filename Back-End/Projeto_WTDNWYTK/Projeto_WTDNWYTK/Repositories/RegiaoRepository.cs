using Projeto_WTDNWYTK.Contexts;
using Projeto_WTDNWYTK.Domains;
using Projeto_WTDNWYTK.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Projeto_WTDNWYTK.Repositories
{
    public class RegiaoRepository : IRegiaoRepository
    {
        WTDNWYTKContext ctx = new WTDNWYTKContext();

        public void Atualizar(int idRegiao, Regiao RegiaoAtualizada)
        {
            Regiao RegiaoBuscada = Listarid(idRegiao);

            if (RegiaoBuscada != null)
            {
                RegiaoBuscada.NomeRegiao = RegiaoAtualizada.NomeRegiao;
            }

            ctx.Regiaos.Update(RegiaoBuscada);

            ctx.SaveChanges();
        }

        public void Cadastrar(Regiao novaRegiao)
        {
            ctx.Regiaos.Add(novaRegiao);

            ctx.SaveChanges();
        }

        public void Deletar(int idRegiao)
        {
            Regiao RegiaoBuscada = Listarid(idRegiao);

            ctx.Regiaos.Remove(RegiaoBuscada);

            ctx.SaveChanges();
        }

        public List<Regiao> Listar()
        {
            return ctx.Regiaos.ToList();
        }

        public Regiao Listarid(int id)
        {
            return ctx.Regiaos.FirstOrDefault(c => c.IdRegiao == id);
        }
    }
}
