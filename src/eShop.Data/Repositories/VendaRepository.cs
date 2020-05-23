using eShop.Domain.Contracts.Repositories;
using eShop.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace eShop.Data.Repositories
{
    public class VendaRepository : IVendaRepository
    {
        public Task<Venda> ObterPorId(int idVenda)
        {
            return Task.FromResult<Venda>(null);
        }
    }
}
