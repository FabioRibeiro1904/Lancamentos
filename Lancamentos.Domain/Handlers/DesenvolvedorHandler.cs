using Flunt.Notifications;
using Lancamentos.Domain.Commands;
using Lancamentos.Domain.Commands.Desenvolvedor;
using Lancamentos.Domain.Commands.Contracts;
using Lancamentos.Domain.Entities;
using Lancamentos.Domain.Handlers.Contracts;
using Lancamentos.Domain.Repository;

namespace Lancamentos.Domain.Handlers
{
    public class DesenvolvedorHandler : Notifiable,
        IHandler<CreateDesenvolvedorCommand>, IHandler<UpdateDesenvolvedorCommand>, IHandler<AddProjetoDesenvolvedorCommand>


    {
        private readonly IProjetoRepository _repositoryProjeto;
        private readonly IDesenvolvedorRepository _repository;

        public DesenvolvedorHandler(IDesenvolvedorRepository repository, IProjetoRepository repositoryProjeto)
        {
            _repository = repository;
            _repositoryProjeto = repositoryProjeto;
        }


        public ICommandResult Handle(CreateDesenvolvedorCommand command)
        {
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(false, "ops, verifique por gentileza os campos.",
                    command.Notifications);

            var desenvolvedor = new Desenvolvedor(command.Nome, command.Cargo);

            _repository.Create(desenvolvedor);


            return new GenericCommandResult(true, "Desenvolvedor criado com sucesso.", desenvolvedor);
        }

        public ICommandResult Handle(UpdateDesenvolvedorCommand command)
        {
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(false, "Ops, verifique por gentileza os campos",
                                                command.Notifications);

            var editarDesenvolvedor = _repository.GetId(command.Id);

            editarDesenvolvedor.UpdateDesenvolvedor(command.Nome, command.Cargo);
            _repository.Update(editarDesenvolvedor);

            return new GenericCommandResult(true, "Cadastro atualizado com sucesso",
                                                command.Notifications);
        }

        public ICommandResult Handle(AddProjetoDesenvolvedorCommand command)
        {
            if (command == null)
                return new GenericCommandResult(false, "Selecione um projeto para adicionar", command);


            var desenvolvedor = _repository.GetId(command.Id);

            var projeto = _repositoryProjeto.GetId(command.ProjetoId);

            desenvolvedor.AddProjeto(projeto);

            _repository.Update(desenvolvedor);

            return new GenericCommandResult(true, "Projeto adicionado com sucesso", desenvolvedor);

            
        }


    }
}
