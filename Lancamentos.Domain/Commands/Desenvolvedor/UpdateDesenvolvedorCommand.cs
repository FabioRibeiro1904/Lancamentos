using Flunt.Notifications;
using Flunt.Validations;
using Lancamentos.Domain.Commands.Contracts;
using System;

namespace Lancamentos.Domain.Commands.Desenvolvedor
{
    public class UpdateDesenvolvedorCommand : Notifiable, ICommand
    {
        public UpdateDesenvolvedorCommand()
        {

        }

        public UpdateDesenvolvedorCommand(Guid id, string nome, string cargo)
        {
            Id = id;
            Nome = nome;
            Cargo = cargo;
        }

        public Guid Id { get; set; }

        public string Nome { get; set; }

        public string Cargo { get; set; }

        public void Validate()
        {
            AddNotifications(
            new Contract()
            .Requires()
            .HasMinLen(Nome, 3, "Nome", "Por favor, digite o nome completo!")
            .HasMinLen(Cargo, 3, "Cargo", "Descreva um cargo")
            );
        }
    }
}
