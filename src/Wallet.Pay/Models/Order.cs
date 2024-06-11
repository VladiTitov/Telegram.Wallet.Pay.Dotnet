using Wallet.Pay.Enums;

namespace Wallet.Pay.Models;

#nullable disable
public class Order
{
    public string Id { get; set; }
    public OrderStatus Status { get; set; }
    public Amount Amount { get; set; }
    public Currency AutoConversionCurrency { get; set; }
    public DateTimeOffset CreatedDateTime { get; set; }
    public DateTimeOffset ExpirationDateTime { get; set; }
}
