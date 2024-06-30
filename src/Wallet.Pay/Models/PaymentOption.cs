namespace Wallet.Pay.Models;

/// <summary>
/// User selected payment option.
/// </summary>
#nullable disable
public class PaymentOption
{
    /// <summary>
    /// <see cref="MoneyAmount"/>
    /// </summary>
    public MoneyAmount Amount { get; set; }

    /// <summary>
    /// <see cref="MoneyAmount"/>
    /// </summary>
    public MoneyAmount AmountFee { get; set; }

    /// <summary>
    /// <see cref="MoneyAmount"/>
    /// </summary>
    public MoneyAmount AmountNet { get; set; }

    /// <summary>
    /// Exchange rate of order.currency to payment.currency
    /// </summary>
    public string ExchangeRate { get; set; }
}
