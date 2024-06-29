namespace Wallet.Pay.Models;

/// <summary>
/// Response payload, present if status is SUCCESS
/// </summary>
#nullable disable
public class OrderPreview
{
    /// <summary>
    /// Order id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// <see cref="OrderStatus"/>
    /// </summary>
    public OrderStatus Status { get; set; }

    /// <summary>
    /// Human-readable short order id shown to a customer
    /// </summary>
    public string Number { get; set; }

    /// <summary>
    /// <see cref="MoneyAmount"/>
    /// </summary>
    public MoneyAmount Amount { get; set; }

    /// <summary>
    /// <see cref="ConversionCurrency"/>
    /// </summary>
    public ConversionCurrency? AutoConversionCurrency { get; set; }

    /// <summary>
    /// ISO-8601 date time when order was created
    /// </summary>
    public DateTimeOffset CreatedDateTime { get; set; }

    /// <summary>
    /// ISO-8601 date time when order timeout expires
    /// </summary>
    public DateTimeOffset ExpirationDateTime { get; set; }

    /// <summary>
    /// ISO-8601 date time when order was completed (paid/expired/etc)
    /// </summary>
    public DateTimeOffset? CompletedDateTime { get; set; }

    /// <summary>
    /// URL to be shown to the payer by the store. Сan be used in 'Telegram Bot' only.
    /// </summary>
    public string PayLink { get; set; }

    /// <summary>
    /// URL to be shown to the payer by the store. Can be used in 'Telegram Bot' and 'Telegram Web App'
    /// </summary>
    public string DirectPayLink { get; set; }
}
