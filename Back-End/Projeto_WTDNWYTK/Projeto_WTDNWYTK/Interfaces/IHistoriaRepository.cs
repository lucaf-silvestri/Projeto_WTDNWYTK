using Projeto_WTDNWYTK.Domains;
using System.Collections.Generic;

namespace Projeto_WTDNWYTK.Interfaces
{
    /// <summary>
    /// Interface responsável pelo repositório HistoriaRepository
    /// </summary>
    interface IHistoriaRepository
    {
        /// <summary>
        /// Lista todas as Historias
        /// </summary>
        /// <returns>Lista de Historias</returns>
        List<Historium> Listar();

        /// <summary>
        /// Busca uma Historia através de seu id
        /// </summary>
        /// <param name="id">id da Historia buscada</param>
        /// <returns>A Historia buscada</returns>
        Historium Listarid(int id);

        /// <summary>
        /// Cadastra uma nova Historia
        /// </summary>
        /// <param name="novaHistoria">Objeto novaHistoria com os novos dados</param>
        void Cadastrar(Historium novaHistoria);

        /// <summary>
        /// Atualiza uma Historia existente passando o id pela URL da requisição
        /// </summary>
        /// <param name="idHistoria">id da Historia que será atualizada</param>
        /// <param name="HistoriaAtualizada">Objeto HistoriaAtualizada com os novos dados</param>
        void Atualizar(int idHistoria, Historium HistoriaAtualizada);

        /// <summary>
        /// Deleta uma Historia existente
        /// </summary>
        /// <param name="idHistoria">id da Historia deletada</param>
        void Deletar(int idHistoria);
    }
}
