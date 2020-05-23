using eShop.Domain.Entities;
using System.Threading.Tasks;

namespace eShop.Domain.Contracts.Repositories
{
    public interface IVendaRepository
    {
        Task<Venda> ObterPorId(int idVenda);
    }
}
