using eShop.Domain.Contracts.Services;
using eShop.Domain.Dtos;
using System.Threading.Tasks;

namespace eShop.Domain.Services
{
    public class VendaPagamentoService : IVendaPagamentoService
    {
        public Task<bool> RealizarPagamentoVenda(DadosPagamentoVenda dadosPagamento)
        {
            return Task.FromResult(true);
        }
    }
}
