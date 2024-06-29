namespace Wallet.Pay.Models;

/// <summary>
/// Order data. SelectedPaymentOption is absent for failed orders. Status is absent for paid orders
/// </summary>
#nullable disable
public class WebhookPayload
{
    /// <summary>
    /// Order id
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Human-readable short order id shown to a customer
    /// </summary>
    public string Number { get; set; }

    /// <summary>
    /// Order ID in Merchant system. Use to prevent orders duplication due to request retries
    /// </summary>
    public string ExternalId { get; set; }

    /// <summary>
    /// <see cref="OrderStatus"/>
    /// </summary>
    public OrderStatus Status {  get; set; }

    /// <summary>
    /// Any custom string, will be provided through webhook and order status polling
    /// </summary>
    public string CustomData { get; set; }

    /// <summary>
    /// <see cref="MoneyAmount"/>
    /// </summary>
    public MoneyAmount MoneyAmount { get; set; }

    /// <summary>
    /// <see cref="PaymentOption"/>
    /// </summary>
    public PaymentOption SelectedPaymentOption { get; set; }

    /// <summary>
    /// ISO 8601 timestamp indicating the time of order completion, in UTC
    /// </summary>
    public DateTimeOffset OrderCompletedDateTime { get; set; }
}
