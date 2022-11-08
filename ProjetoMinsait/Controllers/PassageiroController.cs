﻿using Microsoft.AspNetCore.Mvc;
using ProjetoMinsait.Models;
using ProjetoMinsait.Models.Dtos;
using ProjetoMinsait.Repository;
using ProjetoMinsait.Repository.Interfaces;

namespace ProjetoMinsait.Controllers
{
    [Route("v1/api/[controller]")]
    [ApiController]
    public class PassageiroController : ControllerBase
    {

        private readonly IPassageiroRepositorio _passageiroRepositorio;

        public PassageiroController(IPassageiroRepositorio passageiroRepositorio)
        {
            _passageiroRepositorio = passageiroRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<PassageiroDto>>> BuscarTodosPassageiros()
        {
            List<PassageiroDto> resultado = await _passageiroRepositorio.BuscarTodosPassageiros();
            return resultado.Any() ? Ok(resultado) : BadRequest("Passageiros não encontrados");
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PassageiroDto>> BuscarPorID(Guid id)
        {
            PassageiroDto resultado = await _passageiroRepositorio.BuscarPorID(id);
            return resultado == null ? BadRequest() : Ok(resultado);
        }

        [HttpPost]
        public async Task<ActionResult<PassageiroDto>> Cadastrar([FromBody] Passageiro passageiro) 
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            PassageiroDto resultado = await _passageiroRepositorio.Adicionar(passageiro);
            return Created($"v1/api/passageiro/{resultado.Id}", resultado);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<PassageiroDto>> Atualizar(Guid id, [FromBody] Passageiro passageiro)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            passageiro.Id = id;
            PassageiroDto resultado = await _passageiroRepositorio.Atualizar(id, passageiro);
            return Ok(resultado);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<string>> Deletar(Guid id)
        {
            string resultado = await _passageiroRepositorio.Deletar(id);
            return Ok(resultado);
        }

        [HttpPut("{idPassagem}/vincularCobrador/{nomeVendedor}")]
        public async Task<ActionResult<string>> ComprarPassagem(Guid idPassagem, string nomeVendedor)
        {
            return await _passageiroRepositorio.ComprarPassagem(nomeVendedor, idPassagem);
        }

    }
}
