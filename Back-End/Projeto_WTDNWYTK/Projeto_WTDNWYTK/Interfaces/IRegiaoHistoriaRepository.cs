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
        /// Cadastra uma nova RegiaoHistoria
        /// </summary>
        /// <param name="novaRegiaoHistoria">Objeto novaRegiaoHistoria com os novos dados</param>
        void Cadastrar(RegiaoHistorium novaRegiaoHistoria);
    }
}
