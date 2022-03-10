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
    public class HistoriasController : ControllerBase
    {
        private IHistoriaRepository _HistoriaRepository { get; set; }

        public HistoriasController()
        {
            _HistoriaRepository = new HistoriaRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<Historium> listaHistorias = _HistoriaRepository.Listar();
            return Ok(listaHistorias);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            Historium HistoriaBuscado = _HistoriaRepository.Listarid(id);

            if (HistoriaBuscado == null)
            {
                return NotFound("Nenhuma História encontrada.");
            }

            return Ok(HistoriaBuscado);
        }

        [HttpPost]
        public IActionResult Post(Historium novoHistoria)
        {
            _HistoriaRepository.Cadastrar(novoHistoria);

            return StatusCode(201);
        }

        [HttpDelete("excluir/{id}")]
        public IActionResult Delete(int id)
        {
            _HistoriaRepository.Deletar(id);
            return StatusCode(204);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Historium HistoriaAtualizado)
        {
            Historium HistoriaBuscado = _HistoriaRepository.Listarid(id);

            if (HistoriaBuscado == null)
            {
                return NotFound
                    (new
                    {
                        mensagem = "História não encontrada.",
                        erro = true
                    });
            }

            try
            {
                _HistoriaRepository.Atualizar(id, HistoriaAtualizado);

                return NoContent();
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }
    }
}
