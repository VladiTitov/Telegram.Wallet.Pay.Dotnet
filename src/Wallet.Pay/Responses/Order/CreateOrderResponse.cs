using Wallet.Pay.Models;

namespace Wallet.Pay.Responses.Order;

#nullable disable
internal class CreateOrderResponse
{
    public string Id { get; set; }
    public string Status { get; set; }
    public string Number { get; set; }
    public Amount Amount { get; set; }
    public string AutoConversionCurrency { get; set; }
    public DateTimeOffset CreatedDateTime { get; set; }
    public DateTimeOffset ExpirationDateTime { get; set; }
    public DateTimeOffset CompletedDateTime { get; set; }
    public string PayLink { get; set; }
    public string DirectPayLink { get; set; }
}
