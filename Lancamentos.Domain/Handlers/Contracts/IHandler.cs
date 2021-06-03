using Lancamentos.Domain.Commands.Contracts;

namespace Lancamentos.Domain.Handlers.Contracts
{
    public interface IHandler<T> where T : ICommand
    {
        ICommandResult Handle(T command);
    }
}
