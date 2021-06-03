using Lancamentos.Domain.Commands;
using Lancamentos.Domain.Commands.Desenvolvedor;
using Lancamentos.Domain.Entities;
using Lancamentos.Domain.Handlers;
using Lancamentos.Domain.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Lancamentos.Api.Controllers
{
    public class DesenvolvedorController : Controller
    {
      [Route("desenvolvedor")]
      [HttpGet]
      public IEnumerable<Desenvolvedor> GetAll ( 
          [FromServices] IDesenvolvedorRepository repository)
        {
            return repository.GetList();
        }

        [Route("desenvolvedor/criar")]
        [HttpPost]
        public GenericCommandResult CreateDesenvolvedor(
            [FromBody] CreateDesenvolvedorCommand command,
            [FromServices] DesenvolvedorHandler handle)
        {
            return (GenericCommandResult)handle.Handle(command);
        }

        [Route("desenvolvedor/{id:guid}")]
        [HttpGet]
        public IActionResult GetId( Guid id,
            [FromServices] IDesenvolvedorRepository repository)
        {
            var getDesenvolvedor = repository.GetId(id);
            return Ok(getDesenvolvedor);

        }

        [Route("desenvolvedor/editar")]
        [HttpPut]
        public GenericCommandResult EditarDesenvolvedor(
            [FromBody] UpdateDesenvolvedorCommand command,
            [FromServices] DesenvolvedorHandler handle)
        {
            return (GenericCommandResult)handle.Handle(command);
        }

        [Route("desenvolvedor/delete/{id:guid}")]
        [HttpDelete]
        public IActionResult DeleteDesenvolvedor(Guid id,
            [FromServices] IDesenvolvedorRepository repository)
        {
            repository.Delete(id);
            return NoContent();
        }

        [Route("desenvolvedor/adicionarprojeto")]
        [HttpPut]
        public GenericCommandResult AddProjeto(
            [FromBody] AddProjetoDesenvolvedorCommand command,
            [FromServices] DesenvolvedorHandler handle)
        {
            return (GenericCommandResult)handle.Handle(command);
        }
    }
}
