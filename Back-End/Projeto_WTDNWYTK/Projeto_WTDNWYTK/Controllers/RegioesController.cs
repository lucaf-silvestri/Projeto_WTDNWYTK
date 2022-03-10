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
    public class RegiaosController : ControllerBase
    {
        private IRegiaoRepository _RegiaoRepository { get; set; }

        public RegiaosController()
        {
            _RegiaoRepository = new RegiaoRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<Regiao> listaRegiaos = _RegiaoRepository.Listar();
            return Ok(listaRegiaos);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            Regiao RegiaoBuscado = _RegiaoRepository.Listarid(id);

            if (RegiaoBuscado == null)
            {
                return NotFound("Nenhuma Região encontrada.");
            }

            return Ok(RegiaoBuscado);
        }

        [HttpPost]
        public IActionResult Post(Regiao novoRegiao)
        {
            _RegiaoRepository.Cadastrar(novoRegiao);

            return StatusCode(201);
        }

        [HttpDelete("excluir/{id}")]
        public IActionResult Delete(int id)
        {
            _RegiaoRepository.Deletar(id);
            return StatusCode(204);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Regiao RegiaoAtualizado)
        {
            Regiao RegiaoBuscado = _RegiaoRepository.Listarid(id);

            if (RegiaoBuscado == null)
            {
                return NotFound
                    (new
                    {
                        mensagem = "Região não encontrada.",
                        erro = true
                    });
            }

            try
            {
                _RegiaoRepository.Atualizar(id, RegiaoAtualizado);

                return NoContent();
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }
    }
}
