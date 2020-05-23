﻿using eShop.Domain.Contracts.Services;
using eShop.Domain.Dtos;
using System.Threading.Tasks;

namespace eShop.Integrations.Safe2Pay
{
    public class IntegradorSafe2Pay : IPlayerPagamento
    { 
        public Task<DadosRetornoPlayerPagamento> Integrar(DadosIntegracaoPlayerPagamento dadosIntegracao)
        {
            return Task.FromResult<DadosRetornoPlayerPagamento>(null);
        }
    }
}
