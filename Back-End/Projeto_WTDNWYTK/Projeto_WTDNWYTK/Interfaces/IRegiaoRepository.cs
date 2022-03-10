using Projeto_WTDNWYTK.Domains;
using System.Collections.Generic;

namespace Projeto_WTDNWYTK.Interfaces
{
    /// <summary>
    /// Interface responsável pelo repositório RegiaoRepository
    /// </summary>
    interface IRegiaoRepository
    {
        /// <summary>
        /// Lista todas as Regioes
        /// </summary>
        /// <returns>Lista de Regioes</returns>
        List<Regiao> Listar();

        /// <summary>
        /// Busca uma Regiao através de seu id
        /// </summary>
        /// <param name="id">id da Regiao buscada</param>
        /// <returns>A Regiao buscada</returns>
        Regiao Listarid(int id);

        /// <summary>
        /// Cadastra uma nova Regiao
        /// </summary>
        /// <param name="novaRegiao">Objeto novaRegiao com os novos dados</param>
        void Cadastrar(Regiao novaRegiao);

        /// <summary>
        /// Atualiza uma Regiao existente passando o id pela URL da requisição
        /// </summary>
        /// <param name="idRegiao">id da Regiao que será atualizada</param>
        /// <param name="RegiaoAtualizada">Objeto RegiaoAtualizada com os novos dados</param>
        void Atualizar(int idRegiao, Regiao RegiaoAtualizada);

        /// <summary>
        /// Deleta uma Regiao existente
        /// </summary>
        /// <param name="idRegiao">id da Regiao deletada</param>
        void Deletar(int idRegiao);
    }
}
