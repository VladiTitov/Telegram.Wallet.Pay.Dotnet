namespace Wallet.Pay.Models;

/// <summary>
/// User selected payment option
/// </summary>
#nullable disable
public class OrderReconciliationItem
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
    /// <see cref="MoneyAmount"/>
    /// </summary>
    public MoneyAmount Amount { get; set; }

    /// <summary>
    /// <see cref="ConversionCurrency"/>
    /// </summary>
    public ConversionCurrency? AutoConversionCurrency { get; set; }

    /// <summary>
    /// External ID
    /// </summary>
    public string ExternalId { get; set; }

    /// <summary>
    /// The order customer telegram id
    /// </summary>
    public int? CustomerTelegramUserId { get; set; }

    /// <summary>
    /// ISO-8601 date time when order was created
    /// </summary>
    public DateTimeOffset CreatedDateTime { get; set; }

    /// <summary>
    /// ISO-8601 date time when order timeout expires
    /// </summary>
    public DateTimeOffset ExpirationDateTime { get; set; }

    /// <summary>
    /// ISO-8601 date time when order was paid
    /// </summary>
    public DateTimeOffset? PaymentDateTime { get; set; }

#nullable enable
    /// <summary>
    /// <see cref="PaymentOption"/>
    /// </summary>
    public PaymentOption? SelectedPaymentOption { get; set; }
}
