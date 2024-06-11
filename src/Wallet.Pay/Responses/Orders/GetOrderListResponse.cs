using Wallet.Pay.Models;

namespace Wallet.Pay.Responses.Orders;

#nullable disable
public class GetOrderListResponse
{
    public IEnumerable<Item> Items { get; set; }
}

public class Item : Order
{
    public string ExternalId { get; set; }
    public string CustomerTelegramUserId { get; set; }
    public DateTimeOffset PaymentDateTime { get; set; }
    public SelectedPaymentOption SelectedPaymentOption { get; set; }
}

public class SelectedPaymentOption 
{ 
    public Amount Amount { get; set; }
    public Amount AmountFee { get; set; }
    public Amount AmountNet {  get; set; }
    public string ExchangeRate { get; set; }
}

