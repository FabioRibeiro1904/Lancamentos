using Lancamentos.Domain.Commands;
using Lancamentos.Domain.Entities;
using Lancamentos.Domain.Handlers;
using Lancamentos.Domain.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Lancamentos.Api.Controllers
{
    public class ProjetoController : Controller
    {
        [Route("projetos")]
        [HttpGet]
        public IEnumerable<Projeto> GetAll(
        [FromServices] IProjetoRepository repository)

        {
            return repository.GetList();
        }
        [Route("projeto/{id:guid}")]
        [HttpGet]
        public ActionResult GetById(Guid id,
        [FromServices] IProjetoRepository repository)

        {
            var getById = repository.GetById(id);
            return Ok(getById);
        }

        [Route("projeto/criar")]
        [HttpPost]
        public GenericCommandResult CreateProject(
        [FromBody] CreateProjetoCommand command,
        [FromServices] ProjetoHandler handler)

        {

            return (GenericCommandResult)handler.Handle(command);
        }

        [Route("projeto/atualizar")]
        [HttpPut]
        public GenericCommandResult UpdateProject(
        [FromBody] UpdateProjetoCommand command,
        [FromServices] ProjetoHandler handler)

        {
            return (GenericCommandResult)handler.Handle(command);
        }



        [Route("projeto/delete/{id:guid}")]
        [HttpDelete]
        public IActionResult DeleteProject(Guid id,
        [FromServices] IProjetoRepository projeto)
        {
            projeto.Delete(id);
            return NoContent();

        }

    }
}
