using Wallet.Pay.Models;

namespace Wallet.Pay.Responses.Orders;

#nullable disable
public class GetPreviewOrderResponse : Order
{
    /// <summary>
    /// Human-readable short order id shown to a customer
    /// </summary>
    public string Number { get; set; }

    /// <summary>
    /// ISO-8601 date time when order was completed (paid/expired/etc)
    /// </summary>
    public DateTimeOffset CompletedDateTime { get; set; }

    /// <summary>
    /// URL to be shown to the payer by the store. Сan be used in 'Telegram Bot' only. 
    /// Important: this link can be opened ONLY in dialog with Telegram-bot specified in your Store, 
    /// ONLY by user with telegramUserId specified in the Order.
    /// </summary>
    public string PayLink { get; set; }

    /// <summary>
    /// URL to be shown to the payer by the store. Can be used in 'Telegram Bot' and 'Telegram Web App'. 
    /// Important: this link can be opened ONLY in dialog with Telegram-bot specified in your Store, 
    /// ONLY by user with telegramUserId specified in the Order.
    /// </summary>
    public string DirectPayLink { get; set; }
}
