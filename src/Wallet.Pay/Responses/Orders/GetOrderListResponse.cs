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

    /// <summary>
    /// The order customer telegram id
    /// </summary>
    public string CustomerTelegramUserId { get; set; }

    /// <summary>
    /// ISO-8601 date time when order was paid
    /// </summary>
    public DateTimeOffset PaymentDateTime { get; set; }

    /// <summary>
    /// User selected payment option. Payer paid the amount; you received the amountNet; our service took the amountFee;
    /// </summary>
    public SelectedPaymentOption SelectedPaymentOption { get; set; }
}

public class SelectedPaymentOption 
{ 
    /// <summary>
    /// <see cref="Amount"/>
    /// </summary>
    public Amount Amount { get; set; }

    /// <summary>
    /// <see cref="Amount"/>
    /// </summary>
    public Amount AmountFee { get; set; }

    /// <summary>
    /// <see cref="Amount"/>
    /// </summary>
    public Amount AmountNet {  get; set; }

    /// <summary>
    /// Exchange rate of order.currency to payment.currency
    /// </summary>
    public string ExchangeRate { get; set; }
}

