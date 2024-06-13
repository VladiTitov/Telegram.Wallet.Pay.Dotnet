using Wallet.Pay.Models;
using Wallet.Pay.Responses.Orders;

namespace Wallet.Pay.Requests.Orders;

#nullable disable
[JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
internal class CreateOrderRequest() 
    : RequestBase<CreateOrderResponse>("wpay/store-api/v1/order")
{
    /// <summary>
    /// <see cref="Amount"/>
    /// </summary>
    public Amount Amount { get; set; }

    /// <summary>
    /// Description of the order
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Order ID in Merchant system. Use to prevent orders duplication due to request retries
    /// </summary>
    public string ExternalId { get; set; }

    /// <summary>
    /// Order TTL, if the order is not paid within the timeout period
    /// </summary>
    public int TimeoutSeconds { get; set; }

    /// <summary>
    /// The customer's telegram id (User_id). For more details please follow the link
    /// </summary>
    public int CustomerTelegramUserId { get; set; }

#nullable enable
    /// <summary>
    /// Crypto currency you want to receive no matter what crypto currency the payer will choose to pay
    /// </summary>
    public ConversionCurrency? AutoConversionCurrency { get; set; }

    /// <summary>
    /// Url to redirect after paying order. 
    /// Note: if you want to open your telegram WebApp (https://core.telegram.org/bots/webapps) 
    /// then you should use special link format here (https://core.telegram.org/api/links#named-bot-web-app-links).
    /// </summary>
    public string? ReturnUrl { get; set; }

    /// <summary>
    /// Url to redirect after unsuccessful order completion (expiration/cancelation/etc)
    /// </summary>
    public string? FailReturnUrl { get; set; }

    /// <summary>
    /// Any custom string, will be provided through webhook and order status polling
    /// </summary>
    public string? CustomData { get; set; }
}
