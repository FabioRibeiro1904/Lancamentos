using Flunt.Notifications;
using Flunt.Validations;
using Lancamentos.Domain.Commands.Contracts;
using System;

namespace Lancamentos.Domain.Commands
{
    public class UpdateProjetoCommand : Notifiable, ICommand
    {
        public UpdateProjetoCommand()
        {
        }

        public UpdateProjetoCommand(string nomeProjeto, string tipo, Guid id)
        {
            Id = Id;
            NomeProjeto = nomeProjeto;
            Tipo = tipo;
        }
        public Guid Id { get; set; }

        public string NomeProjeto { get; set; }

        public string Tipo { get; set; }

        public void Validate()
        {
            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(NomeProjeto, 6, "Nome", "Por favor digite o nome completo")
                .HasMinLen(Tipo, 3, "Tipo", "Por favor descreva melhor o tipo")
                );
        }
    }
}
