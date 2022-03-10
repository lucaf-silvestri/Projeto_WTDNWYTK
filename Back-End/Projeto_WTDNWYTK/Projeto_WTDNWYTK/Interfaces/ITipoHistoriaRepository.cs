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
        /// Cadastra um novo TipoHistoria
        /// </summary>
        /// <param name="novoTipoHistoria">Objeto novoTipoHistoria com os novos dados</param>
        void Cadastrar(TipoHistorium novoTipoHistoria);
    }
}
