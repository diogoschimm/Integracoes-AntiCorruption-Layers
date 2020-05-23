using eShop.Domain.DomainObjects;
using System.Threading.Tasks;

namespace eShop.Domain.Contracts.Communications
{
    public interface  IRequestHandler<TCommand, TResult> where TCommand : Command 
    {
        Task<TResult> Handle(TCommand command);
    }
}
