using Flunt.Notifications;
using Lancamentos.Domain.Commands;
using Lancamentos.Domain.Commands.Contracts;
using Lancamentos.Domain.Entities;
using Lancamentos.Domain.Handlers.Contracts;
using Lancamentos.Domain.Repository;

namespace Lancamentos.Domain.Handlers
{
    public class ProjetoHandler : Notifiable,
        IHandler<CreateProjetoCommand>, IHandler<UpdateProjetoCommand>
    {

        private readonly IProjetoRepository _repository;
        public ProjetoHandler(IProjetoRepository projeto)
        {
            _repository = projeto;
        }

        public ICommandResult Handle(CreateProjetoCommand command)
        {
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(false, "Ops, Por favor reveja os campos preenchidos",
                    command.Notifications);

            var projeto = new Projeto(command.NomeProjeto, command.Tipo);

            _repository.Create(projeto);

            return new GenericCommandResult(true, "Projeto criado com sucesso", projeto);

        }

        public ICommandResult Handle(UpdateProjetoCommand command)
        {
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(false, "ops, Por favor reveja os campos preenchidos",
                    command.Notifications);

            var projeto = _repository.GetId(command.Id);

            projeto.UpdateTitle(command.NomeProjeto, command.Tipo);


            _repository.Update(projeto);

            return new GenericCommandResult(true, "Projeto atualizado com sucesso", projeto);
        }
    }
}
