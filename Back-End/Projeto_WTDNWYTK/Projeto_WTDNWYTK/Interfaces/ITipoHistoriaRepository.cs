using Projeto_WTDNWYTK.Domains;
using System.Collections.Generic;

namespace Projeto_WTDNWYTK.Interfaces
{
    /// <summary>
    /// Interface responsável pelo repositório TipoHistoriaRepository
    /// </summary>
    interface ITipoHistoriaRepository
    {
        /// <summary>
        /// Lista todos os TipoHistorias
        /// </summary>
        /// <returns>Lista de TipoHistorias</returns>
        List<TipoHistorium> Listar();

        /// <summary>
        /// Busca um TipoHistoria através de seu id
        /// </summary>
        /// <param name="id">id do TipoHistoria buscado</param>
        /// <returns>O TipoHistoria buscado</returns>
        TipoHistorium Listarid(int id);

        /// <summary>
        /// Cadastra um novo TipoHistoria
        /// </summary>
        /// <param name="novoTipoHistoria">Objeto novoTipoHistoria com os novos dados</param>
        void Cadastrar(TipoHistorium novoTipoHistoria);

        /// <summary>
        /// Atualiza um TipoHistoria existente passando o id pela URL da requisição
        /// </summary>
        /// <param name="idTipoHistoria">id do TipoHistoria que será atualizado</param>
        /// <param name="TipoHistoriaAtualizado">Objeto TipoHistoriaAtualizado com os novos dados</param>
        void Atualizar(int idTipoHistoria, TipoHistorium TipoHistoriaAtualizado);

        /// <summary>
        /// Deleta um TipoHistoria existente
        /// </summary>
        /// <param name="idTipoHistoria">id do TipoHistoria deletado</param>
        void Deletar(int idTipoHistoria);
    }
}
