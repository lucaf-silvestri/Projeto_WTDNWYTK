using Projeto_WTDNWYTK.Domains;
using System.Collections.Generic;

namespace Projeto_WTDNWYTK.Interfaces
{
    /// <summary>
    /// Interface responsável pelo repositório TipoRepository
    /// </summary>
    interface ITipoRepository
    {
        /// <summary>
        /// Lista todos os Tipos
        /// </summary>
        /// <returns>Lista de Tipos</returns>
        List<Tipo> Listar();

        /// <summary>
        /// Busca um Tipo através de seu id
        /// </summary>
        /// <param name="id">id do Tipo buscado</param>
        /// <returns>O Tipo buscado</returns>
        Tipo Listarid(int id);

        /// <summary>
        /// Cadastra um novo Tipo
        /// </summary>
        /// <param name="novoTipo">Objeto novoTipo com os novos dados</param>
        void Cadastrar(Tipo novoTipo);

        /// <summary>
        /// Atualiza um Tipo existente passando o id pela URL da requisição
        /// </summary>
        /// <param name="idTipo">id do Tipo que será atualizado</param>
        /// <param name="TipoAtualizado">Objeto TipoAtualizado com os novos dados</param>
        void Atualizar(int idTipo, Tipo TipoAtualizado);

        /// <summary>
        /// Deleta um Tipo existente
        /// </summary>
        /// <param name="idTipo">id do Tipo deletado</param>
        void Deletar(int idTipo);
    }
}
