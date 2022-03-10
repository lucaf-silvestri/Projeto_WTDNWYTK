using Microsoft.AspNetCore.Mvc;
using Projeto_WTDNWYTK.Domains;
using Projeto_WTDNWYTK.Interfaces;
using Projeto_WTDNWYTK.Repositories;
using System;
using System.Collections.Generic;

namespace Projeto_WTDNWYTK.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class RegiaoHistoriasController : ControllerBase
    {
        private IRegiaoHistoriaRepository _RegiaoHistoriaRepository { get; set; }

        public RegiaoHistoriasController()
        {
            _RegiaoHistoriaRepository = new RegiaoHistoriaRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<RegiaoHistorium> listaRegiaoHistorias = _RegiaoHistoriaRepository.Listar();
            return Ok(listaRegiaoHistorias);
        }

        [HttpPost]
        public IActionResult Post(RegiaoHistorium novoRegiaoHistoria)
        {
            _RegiaoHistoriaRepository.Cadastrar(novoRegiaoHistoria);

            return StatusCode(201);
        }
    }
}
