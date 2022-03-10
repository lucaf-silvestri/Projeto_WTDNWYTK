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
    public class TipoHistoriasController : ControllerBase
    {
        private ITipoHistoriaRepository _TipoHistoriaRepository { get; set; }

        public TipoHistoriasController()
        {
            _TipoHistoriaRepository = new TipoHistoriaRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<TipoHistorium> listaTipoHistorias = _TipoHistoriaRepository.Listar();
            return Ok(listaTipoHistorias);
        }

        [HttpPost]
        public IActionResult Post(TipoHistorium novoTipoHistoria)
        {
            _TipoHistoriaRepository.Cadastrar(novoTipoHistoria);

            return StatusCode(201);
        }
    }
}
