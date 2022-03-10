using Projeto_WTDNWYTK.Contexts;
using Projeto_WTDNWYTK.Domains;
using Projeto_WTDNWYTK.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Projeto_WTDNWYTK.Repositories
{
    public class HistoriaRepository : IHistoriaRepository
    {
        WTDNWYTKContext ctx = new WTDNWYTKContext();

        public void Atualizar(int idHistoria, Historium HistoriaAtualizada)
        {
            Historium HistoriaBuscada = Listarid(idHistoria);

            if (HistoriaBuscada != null)
            {
                HistoriaBuscada.IdUsuario = HistoriaAtualizada.IdUsuario;
                HistoriaBuscada.Titulo = HistoriaAtualizada.Titulo;
                HistoriaBuscada.Texto = HistoriaAtualizada.Texto;
                HistoriaBuscada.Imagem1 = HistoriaAtualizada.Imagem1;
                HistoriaBuscada.Imagem2 = HistoriaAtualizada.Imagem2;
            }

            ctx.Historia.Update(HistoriaBuscada);

            ctx.SaveChanges();
        }

        public void Cadastrar(Historium novaHistoria)
        {
            ctx.Historia.Add(novaHistoria);

            ctx.SaveChanges();
        }

        public void Deletar(int idHistoria)
        {
            Historium HistoriaBuscada = Listarid(idHistoria);

            ctx.Historia.Remove(HistoriaBuscada);

            ctx.SaveChanges();
        }

        public List<Historium> Listar()
        {
            return ctx.Historia
                .Select(c => new Historium
                {
                    IdHistoria = c.IdHistoria,
                    IdUsuario = c.IdUsuario,
                    Titulo = c.Titulo,
                    Texto = c.Texto,
                    Imagem1 = c.Imagem1,
                    Imagem2 = c.Imagem2,

                    IdUsuarioNavigation = new Usuario
                    {
                        Nome = c.IdUsuarioNavigation.Nome,
                        Email = c.IdUsuarioNavigation.Email,
                        Senha = c.IdUsuarioNavigation.Senha,
                    }
                }).ToList();
        }

        public Historium Listarid(int id)
        {
            return ctx.Historia.FirstOrDefault(c => c.IdHistoria == id);
        }
    }
}
