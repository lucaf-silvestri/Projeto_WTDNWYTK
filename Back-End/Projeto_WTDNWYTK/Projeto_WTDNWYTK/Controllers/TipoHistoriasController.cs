using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Projeto_WTDNWYTK.Domains;
using Projeto_WTDNWYTK.Interfaces;
using Projeto_WTDNWYTK.Repositories;

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

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            TipoHistorium TipoHistoriaBuscado = _TipoHistoriaRepository.Listarid(id);

            if (TipoHistoriaBuscado == null)
            {
                return NotFound("Nenhuma TipoHistória encontrada.");
            }

            return Ok(TipoHistoriaBuscado);
        }

        [HttpPost]
        public IActionResult Post(TipoHistorium novoTipoHistoria)
        {
            _TipoHistoriaRepository.Cadastrar(novoTipoHistoria);

            return StatusCode(201);
        }

        [HttpDelete("excluir/{id}")]
        public IActionResult Delete(int id)
        {
            _TipoHistoriaRepository.Deletar(id);
            return StatusCode(204);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, TipoHistorium TipoHistoriaAtualizado)
        {
            TipoHistorium TipoHistoriaBuscado = _TipoHistoriaRepository.Listarid(id);

            if (TipoHistoriaBuscado == null)
            {
                return NotFound
                    (new
                    {
                        mensagem = "TipoHistória não encontrada.",
                        erro = true
                    });
            }

            try
            {
                _TipoHistoriaRepository.Atualizar(id, TipoHistoriaAtualizado);

                return NoContent();
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }
    }
}
