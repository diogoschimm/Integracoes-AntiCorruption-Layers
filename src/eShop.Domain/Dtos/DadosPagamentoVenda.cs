using eShop.Domain.Entities;

namespace eShop.Domain.Dtos
{
    public class DadosPagamentoVenda
    {
        public Venda Venda { get; set; }
        public DadosRetornoPlayerPagamento DadosRetornoPlayerPagamento { get; set; }
    }
}
