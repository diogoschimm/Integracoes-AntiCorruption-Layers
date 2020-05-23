using eShop.Domain.Contracts.Services;
using eShop.Domain.Dtos;
using System.Threading.Tasks;

namespace eShop.Integrations.Iugu
{
    public class IntegradorIugu : IPlayerPagamento
    { 
        public Task<DadosRetornoPlayerPagamento> Integrar(DadosIntegracaoPlayerPagamento dadosIntegracao)
        {
            return Task.FromResult<DadosRetornoPlayerPagamento>(null);
        }
    }
}
