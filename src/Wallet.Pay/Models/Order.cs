namespace Wallet.Pay.Models;

/// <summary>
/// Order model
/// </summary>
#nullable disable
public class Order
{
    /// <summary>
    /// Order id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Order status
    /// </summary>
    public OrderStatus Status { get; set; }

    /// <summary>
    /// <see cref="Amount"/>
    /// </summary>
    public Amount Amount { get; set; }

    /// <summary>
    /// Crypto currency you want to receive no matter what crypto currency the payer will choose to pay.
    /// </summary>
    public Currency? AutoConversionCurrency { get; set; }

    /// <summary>
    /// ISO-8601 date time when order was created
    /// </summary>
    public DateTimeOffset CreatedDateTime { get; set; }

    /// <summary>
    /// ISO-8601 date time when order timeout expires
    /// </summary>
    public DateTimeOffset ExpirationDateTime { get; set; }
}
