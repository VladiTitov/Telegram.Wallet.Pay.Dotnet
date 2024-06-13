using Wallet.Pay.Enums;
using Wallet.Pay.Requests.Orders;

namespace Wallet.Pay.Tests.Integrations;

internal class DataGeneratorHelper
{
    private readonly CreateOrderRequest _createOrderRequest;

    public DataGeneratorHelper()
    {
        var externalId = Guid.NewGuid().ToString();
        _createOrderRequest = new()
        {
            Amount = new(0.01, Currency.TON),
            ExternalId = externalId,
            Description = "VPN for 1 month",
            TimeoutSeconds = 10800,
            CustomerTelegramUserId = 111
        };
    }

    internal CreateOrderRequest GetCreateOrderRequest() => _createOrderRequest;
}
