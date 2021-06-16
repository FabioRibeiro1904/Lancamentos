using Lancamentos.Domain.Commands;
using Lancamentos.Domain.Commands.Contracts;
using Lancamentos.Domain.Commands.Lancamento;
using Lancamentos.Domain.Entities;
using Lancamentos.Domain.Handlers.Contracts;
using Lancamentos.Domain.Repository;
using System.Collections.Generic;

namespace Lancamentos.Domain.Handlers
{
    public class LancamentoHandler : IHandler<CreateLancamentoCommand>
    {
        private readonly ILancamentoRepository _repository;
        private readonly IDesenvolvedorRepository _repositoryDev;

        public LancamentoHandler(ILancamentoRepository repository, IDesenvolvedorRepository repositoryDev)
        {
            _repository = repository;
            _repositoryDev = repositoryDev;
        }

        public ICommandResult Handle(CreateLancamentoCommand command)
        {
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(false, "Verifique se preencheu todos os campos", command.Notifications);


            var dev = _repository.GetDev(command.Id);

            var lancamento = new Lancamento(command.DataInicio, command.DataFim);

            lancamento.AddDesenvolvedor(dev);

            _repository.Create(lancamento);

            return new GenericCommandResult(true, "Lançamento gerado com sucesso", lancamento);
        }
    }
}
