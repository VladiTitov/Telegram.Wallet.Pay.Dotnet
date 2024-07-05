namespace Wallet.Pay.Webhooks;

/// <summary>
/// Notification about completed Order
/// </summary>
#nullable disable
public class WebhookMessage
{
    /// <summary>
    /// Idempotency key. We send a max of one type of webhook message for one event
    /// </summary>
    public long EventId { get; set; }

    /// <summary>
    /// <see cref="WebhookMessageType"/>
    /// </summary>
    public WebhookMessageType Type { get; set; }

    /// <summary>
    /// ISO-8601 when order was completed
    /// </summary>
    public DateTimeOffset EventDateTime { get; set; }

    /// <summary>
    /// <see cref="WebhookPayload"/>
    /// </summary>
    public WebhookPayload Payload { get; set; }
}
