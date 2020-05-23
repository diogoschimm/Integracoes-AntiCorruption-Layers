using eShop.Domain.Contracts.Services;
using eShop.Domain.DomainObjects;

namespace eShop.Application.Commands
{
    public class RealizarPagamentoVendaCommand : Command
    {
        public IPlayerPagamento TipoPlayerPagamento { get; set; }

        public int IdVenda { get; set; }

        public override bool ValidarComando()
        {
            return true;
        }
    }
}
