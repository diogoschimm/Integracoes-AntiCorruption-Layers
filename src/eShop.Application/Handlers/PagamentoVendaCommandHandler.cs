using eShop.Application.Commands;
using eShop.Domain.Contracts.Communications;
using eShop.Domain.Contracts.Repositories;
using eShop.Domain.Contracts.Services;
using eShop.Domain.Dtos;
using eShop.Domain.Entities;
using System.Threading.Tasks;

namespace eShop.Application.Handlers
{
    public class PagamentoVendaCommandHandler : IRequestHandler<RealizarPagamentoVendaCommand, bool>
    {
        private readonly IVendaRepository _vendaRepository;
        private readonly IVendaPagamentoService _vendaPagamentoService;

        public PagamentoVendaCommandHandler(IVendaRepository vendaRepository, IVendaPagamentoService vendaPagamentoService)
        {
            this._vendaRepository = vendaRepository;
            this._vendaPagamentoService = vendaPagamentoService;
        }

        public Task<bool> Handle(RealizarPagamentoVendaCommand command)
        {
            command.ValidarComando();

            var venda = _vendaRepository.ObterPorId(command.IdVenda).Result;

            var dadosIntegracao = new DadosIntegracaoPlayerPagamento();
            var retorno = command.TipoPlayerPagamento.Integrar(dadosIntegracao).Result;

            this.ProcessarRetornoPlayerPagamento(retorno, venda);

            return Task.FromResult(true);
        }

        private void ProcessarRetornoPlayerPagamento(DadosRetornoPlayerPagamento retorno, Venda venda)
        {
            if (!retorno.Sucesso) return;

            var dadosPagamentoVenda = new DadosPagamentoVenda
            {
                DadosRetornoPlayerPagamento = retorno,
                Venda = venda
            };

            _vendaPagamentoService.RealizarPagamentoVenda(dadosPagamentoVenda);
        }
    }
}
