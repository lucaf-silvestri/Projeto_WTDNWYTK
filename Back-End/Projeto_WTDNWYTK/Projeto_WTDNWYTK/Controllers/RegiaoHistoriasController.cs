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

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            RegiaoHistorium RegiaoHistoriaBuscado = _RegiaoHistoriaRepository.Listarid(id);

            if (RegiaoHistoriaBuscado == null)
            {
                return NotFound("Nenhuma RegiãoHistória encontrada.");
            }

            return Ok(RegiaoHistoriaBuscado);
        }

        [HttpPost]
        public IActionResult Post(RegiaoHistorium novoRegiaoHistoria)
        {
            _RegiaoHistoriaRepository.Cadastrar(novoRegiaoHistoria);

            return StatusCode(201);
        }

        [HttpDelete("excluir/{id}")]
        public IActionResult Delete(int id)
        {
            _RegiaoHistoriaRepository.Deletar(id);
            return StatusCode(204);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, RegiaoHistorium RegiaoHistoriaAtualizado)
        {
            RegiaoHistorium RegiaoHistoriaBuscado = _RegiaoHistoriaRepository.Listarid(id);

            if (RegiaoHistoriaBuscado == null)
            {
                return NotFound
                    (new
                    {
                        mensagem = "RegiãoHistória não encontrada.",
                        erro = true
                    });
            }

            try
            {
                _RegiaoHistoriaRepository.Atualizar(id, RegiaoHistoriaAtualizado);

                return NoContent();
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }
    }
}
