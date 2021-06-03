using Flunt.Notifications;
using Flunt.Validations;
using Lancamentos.Domain.Commands.Contracts;

namespace Lancamentos.Domain.Commands.Desenvolvedor
{
    public class CreateDesenvolvedorCommand : Notifiable, ICommand
    {
        public CreateDesenvolvedorCommand()
        {
        }

        public CreateDesenvolvedorCommand(string nome, string cargo)
        {
            Nome = nome;
            Cargo = cargo;
        }

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
