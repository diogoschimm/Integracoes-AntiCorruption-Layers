using eShop.Domain.Dtos;
using eShop.Domain.Entities;
using System.Threading.Tasks;

namespace eShop.Domain.Contracts.Services
{
    public interface IVendaPagamentoService
    {
        Task<bool> RealizarPagamentoVenda(DadosPagamentoVenda dadosPagamento);
    }
}
