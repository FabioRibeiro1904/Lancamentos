//using Flunt.Notifications;
//using Lancamentos.Domain.Commands;
//using Lancamentos.Domain.Commands.Contracts;
//using Lancamentos.Domain.Handlers.Contracts;
//using Lancamentos.Domain.Repository;

//namespace Lancamentos.Domain.Handlers
//{
//    public class LancamentoHandler : Notifiable, IHandler<AddLancamentoDesenvolvedorCommand>
//    {
//        private readonly IDesenvolvedorRepository _repository;

//        public LancamentoHandler(IDesenvolvedorRepository repository)
//        {
//            _repository = repository;
//        }

//        public ICommandResult Handle(AddLancamentoDesenvolvedorCommand command)
//        {
//            command.Validate();
//            if (command.Invalid)
//                return new GenericCommandResult(false, "Verifique se preencheu todos os campos",
//                    Notifications);


//            return new GenericCommandResult(true, "Horas gravadas com sucesso", Notifications);

//        }
//    }
//}
