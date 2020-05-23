
using eShop.Domain.Contracts.Services;
using eShop.Integrations.Cielo.Api;
using eShop.Integrations.Cielo.WebService;
using eShop.Integrations.GooglePay;
using eShop.Integrations.Iugu;
using eShop.Integrations.PayPal;
using eShop.Integrations.Safe2Pay;
using eShop.Integrations.WireCard;

namespace eShop.Application.Enumerations
{
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
}
