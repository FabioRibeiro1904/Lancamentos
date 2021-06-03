using Flunt.Notifications;
using Flunt.Validations;
using Lancamentos.Domain.Commands.Contracts;

namespace Lancamentos.Domain.Commands
{
    public class CreateProjetoCommand : Notifiable, ICommand
    {
        public CreateProjetoCommand()
        {
        }
        public CreateProjetoCommand(string nomeProjeto, string tipo)
        {
            NomeProjeto = nomeProjeto;
            Tipo = tipo;
        }

        public string NomeProjeto { get; set; }

        public string Tipo { get; set; }


        public void Validate()
        {
            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(NomeProjeto, 3, "Nome", "Por favor digite o nome completo do projeto")
                .HasMinLen(Tipo, 3, "Tipo", "Por favor defina melhor o tipo do proejto")
                );
        }
    }
}
