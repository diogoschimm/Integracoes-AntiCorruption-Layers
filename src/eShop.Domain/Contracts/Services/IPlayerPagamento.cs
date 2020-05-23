using eShop.Domain.Dtos;
using System.Threading.Tasks;

namespace eShop.Domain.Contracts.Services
{
    public interface IPlayerPagamento
    { 
        Task<DadosRetornoPlayerPagamento> Integrar(DadosIntegracaoPlayerPagamento dadosIntegracao);
    }
}
