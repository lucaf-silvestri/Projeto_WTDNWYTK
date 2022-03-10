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
    public class TiposController : ControllerBase
    {
        private ITipoRepository _TipoRepository { get; set; }

        public TiposController()
        {
            _TipoRepository = new TipoRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<Tipo> listaTipos = _TipoRepository.Listar();
            return Ok(listaTipos);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            Tipo TipoBuscado = _TipoRepository.Listarid(id);

            if (TipoBuscado == null)
            {
                return NotFound("Nenhum Tipo encontrado.");
            }

            return Ok(TipoBuscado);
        }

        [HttpPost]
        public IActionResult Post(Tipo novoTipo)
        {
            _TipoRepository.Cadastrar(novoTipo);

            return StatusCode(201);
        }

        [HttpDelete("excluir/{id}")]
        public IActionResult Delete(int id)
        {
            _TipoRepository.Deletar(id);
            return StatusCode(204);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Tipo TipoAtualizado)
        {
            Tipo TipoBuscado = _TipoRepository.Listarid(id);

            if (TipoBuscado == null)
            {
                return NotFound
                    (new
                    {
                        mensagem = "Tipo não encontrado.",
                        erro = true
                    });
            }

            try
            {
                _TipoRepository.Atualizar(id, TipoAtualizado);

                return NoContent();
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }
    }
}
