using Projeto_WTDNWYTK.Domains;
using System.Collections.Generic;

namespace Projeto_WTDNWYTK.Interfaces
{
    /// <summary>
    /// Interface responsável pelo repositório RegiaoHistoriaRepository
    /// </summary>
    interface IRegiaoHistoriaRepository
    {
        /// <summary>
        /// Lista todas as RegiaoHistorias
        /// </summary>
        /// <returns>Lista de RegiaoHistorias</returns>
        List<RegiaoHistorium> Listar();

        /// <summary>
        /// Busca uma RegiaoHistoria através de seu id
        /// </summary>
        /// <param name="id">id da RegiaoHistoria buscada</param>
        /// <returns>A RegiaoHistoria buscada</returns>
        RegiaoHistorium Listarid(int id);

        /// <summary>
        /// Cadastra uma nova RegiaoHistoria
        /// </summary>
        /// <param name="novaRegiaoHistoria">Objeto novaRegiaoHistoria com os novos dados</param>
        void Cadastrar(RegiaoHistorium novaRegiaoHistoria);

        /// <summary>
        /// Atualiza uma RegiaoHistoria existente passando o id pela URL da requisição
        /// </summary>
        /// <param name="idRegiaoHistoria">id da RegiaoHistoria que será atualizada</param>
        /// <param name="RegiaoHistoriaAtualizada">Objeto RegiaoHistoriaAtualizada com os novos dados</param>
        void Atualizar(int idRegiaoHistoria, RegiaoHistorium RegiaoHistoriaAtualizada);

        /// <summary>
        /// Deleta uma RegiaoHistoria existente
        /// </summary>
        /// <param name="idRegiaoHistoria">id da RegiaoHistoria deletada</param>
        void Deletar(int idRegiaoHistoria);
    }
}
