using Wallet.Pay.Models;

namespace Wallet.Pay.Responses.Orders;

#nullable disable
public class GetPreviewOrderResponse : Order
{
    public string Number { get; set; }
    public DateTimeOffset CompletedDateTime { get; set; }
    public string PayLink { get; set; }
    public string DirectPayLink { get; set; }
}
