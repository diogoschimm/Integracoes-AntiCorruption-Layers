using eShop.Domain.Contracts.Communications;

namespace eShop.Domain.DomainObjects
{
    public abstract class Command : IRequest
    {
        public abstract bool ValidarComando();
    }
}
