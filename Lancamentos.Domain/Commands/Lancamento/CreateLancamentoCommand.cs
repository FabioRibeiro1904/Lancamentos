using Flunt.Notifications;
using Flunt.Validations;
using Lancamentos.Domain.Commands.Contracts;
using System;

namespace Lancamentos.Domain.Commands.Lancamento
{
    public class CreateLancamentoCommand:Notifiable, ICommand
    {
        public CreateLancamentoCommand()
        {

        }

        public CreateLancamentoCommand(DateTime dataInicio, DateTime dataFim, Guid id)
        {
            Id = id;
            DataInicio = dataInicio;
            DataFim = dataFim;
            
        }

        public Guid Id { get; set; }

        public DateTime DataInicio { get;  set; }

        public DateTime DataFim { get;  set; }

        public void Validate()
        {
           
        }
    }
}
