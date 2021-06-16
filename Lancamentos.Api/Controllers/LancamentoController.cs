using Lancamentos.Domain.Commands;
using Lancamentos.Domain.Commands.Lancamento;
using Lancamentos.Domain.Entities;
using Lancamentos.Domain.Handlers;
using Lancamentos.Domain.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Lancamentos.Api.Controllers
{
    public class LancamentoController : Controller
    {

        [Route("lancamento")]
        [HttpGet]
        public IEnumerable<Desenvolvedor> GetAll(
            [FromServices] ILancamentoRepository repository)
        {
            return repository.GetList();
        }

        [Route("lancamento/criar")]
        [HttpPost]
        public GenericCommandResult CreateLancamento(
            [FromBody]CreateLancamentoCommand command,
            [FromServices] LancamentoHandler handle)
        {
            return (GenericCommandResult)handle.Handle(command);
        }

    }
}
