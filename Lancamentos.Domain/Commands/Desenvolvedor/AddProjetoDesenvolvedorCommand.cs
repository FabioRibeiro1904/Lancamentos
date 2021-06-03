using Flunt.Notifications;
using Lancamentos.Domain.Commands.Contracts;
using System;

namespace Lancamentos.Domain.Commands.Desenvolvedor
{ 

    public class AddProjetoDesenvolvedorCommand : Notifiable, ICommand
    {
        public AddProjetoDesenvolvedorCommand()
        {

        }

        public AddProjetoDesenvolvedorCommand(Guid id, Guid projetoId)
        {
            Id = id;
            ProjetoId = projetoId;
        }

        public Guid Id { get; set; }

        public string Nome { get; set; }

        public string Cargo { get; set; }

        public Guid ProjetoId { get; set; }

        public void Validate()
        {
            throw new NotImplementedException();
        }
    }
}

