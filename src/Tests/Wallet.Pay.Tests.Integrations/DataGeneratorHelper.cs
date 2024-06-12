using Wallet.Pay.Models;
using Wallet.Pay.Requests.Orders;

namespace Wallet.Pay.Tests.Integrations;

internal class DataGeneratorHelper
{
    private readonly CreateOrderRequest _createOrderRequest;

    public DataGeneratorHelper()
    {
        _createOrderRequest = new()
        {
            Amount = new Amount
            {
                Value = "0.01",
                CurrencyCode = "TON"
            },
            ExternalId = "ORD-5023-4E87",
            TimeoutSeconds = 10800,
            Description = "VPN for 1 month",
            ReturnUrl = "https://t.me/wallet",
            FailReturnUrl = "https://t.me/wallet",
            CustomData = "client_ref=4E887",
            CustomerTelegramUserId = 111
        };
    }

    internal CreateOrderRequest GetCreateOrderRequest() => _createOrderRequest;
}
