using Wallet.Pay.Models;
using Wallet.Pay.Responses.Orders;

namespace Wallet.Pay.Requests.Orders;

#nullable disable
internal class CreateOrderRequest() 
    : RequestBase<CreateOrderResponse>("wpay/store-api/v1/order")
{
    public Amount Amount { get; set; }
    public string AutoConversionCurrency {  get; set; }
    public string Description { get; set; }
    public string ReturnUrl { get; set; }
    public string FailReturnUrl { get; set; }
    public string CustomData { get; set; }
    public string ExternalId { get; set; }
    public int TimeoutSeconds { get; set; }
    public int CustomerTelegramUserId { get; set; }
}
