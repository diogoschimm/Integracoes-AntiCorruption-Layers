# Integracoes-AntiCorruption-Layers
Exemplo de Integrações com Player de Pagamento utilizando um camadas anticorrupção, classe de enumeração

## Command Handler

```c#
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
```

## Classe de Enumeração

```c#
    public static class TipoPlayerPagamento  
    {
        public static readonly IPlayerPagamento CieloApi = new IntegradorCieloApi();
        public static readonly IPlayerPagamento CieloWebService = new IntegradorCieloWebService();
        public static readonly IPlayerPagamento Iugu = new IntegradorIugu();
        public static readonly IPlayerPagamento PayPal = new IntegradorPayPal();
        public static readonly IPlayerPagamento Safe2Pay = new IntegradorSafe2Pay();
        public static readonly IPlayerPagamento WireCard = new IntegradorWireCard();
        public static readonly IPlayerPagamento GooglePay = new IntegradorGooglePay();        
    }
```

## Interface Facade Para Processamento do Player de Pagamento

```c#
    public interface IPlayerPagamento
    { 
        Task<DadosRetornoPlayerPagamento> Integrar(DadosIntegracaoPlayerPagamento dadosIntegracao);
    }
```


