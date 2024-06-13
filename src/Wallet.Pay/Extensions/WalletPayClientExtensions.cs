using Wallet.Pay.Requests.Orders;
using Wallet.Pay.Responses.Orders;

namespace Wallet.Pay.Extensions;

public static class WalletPayClientExtensions
{
    /// <summary>
    /// Create an order
    /// </summary>
    /// <param name="walletPayClient"></param>
    /// <param name="amount"></param>
    /// <param name="currency"></param>
    /// <param name="description">Description of the order</param>
    /// <param name="externalId">Order ID in Merchant system. Use to prevent orders duplication due to request retries</param>
    /// <param name="timeoutSeconds">Order TTL, if the order is not paid within the timeout period</param>
    /// <param name="customerTelegramUserId">The customer's telegram id (User_id)</param>
    /// <param name="autoConversionCurrency">Crypto currency you want to receive no matter what crypto currency the payer will choose to pay.</param>
    /// <param name="returnUrl">Url to redirect after paying order</param>
    /// <param name="failReturnUrl">Url to redirect after unsuccessful order completion</param>
    /// <param name="customData">Any custom string, will be provided through webhook and order status polling</param>
    /// <param name="cancellationToken"></param>
    /// <returns>CreateOrderResponse</returns>
    public static Task<IResponse<CreateOrderResponse>> CreateOrderAsync(
        this IWalletPayClient walletPayClient,
        double amount,
        Currency currency,
        string description,
        string externalId,
        int timeoutSeconds,
        int customerTelegramUserId,
        ConversionCurrency? autoConversionCurrency = null,
        string? returnUrl = default,
        string? failReturnUrl = default,
        string? customData = default,
        CancellationToken cancellationToken = default)
        => walletPayClient.MakeRequestAsync(
            request: new CreateOrderRequest()
            {
                Amount = new(amount, currency),
                Description = description,
                ExternalId = externalId,
                TimeoutSeconds = timeoutSeconds,
                CustomerTelegramUserId = customerTelegramUserId,
                AutoConversionCurrency = autoConversionCurrency,
                ReturnUrl = returnUrl,
                FailReturnUrl = failReturnUrl,
                CustomData = customData
            },
            cancellationToken: cancellationToken);

    /// <summary>
    /// Retrieve the order information
    /// </summary>
    /// <param name="walletPayClient"></param>
    /// <param name="id">Order id</param>
    /// <param name="cancellationToken"></param>
    /// <returns>GetPreviewOrderResponse</returns>
    public static Task<IResponse<GetPreviewOrderResponse>> GetPreviewOrderAsync(
        this IWalletPayClient walletPayClient,
        string id,
        CancellationToken cancellationToken = default)
        => walletPayClient.MakeRequestAsync(
            request: new GetPreviewOrderRequest(id),
            cancellationToken: cancellationToken);

    /// <summary>
    /// Return list of store orders sorted by creation time in ascending order
    /// </summary>
    /// <param name="walletPayClient"></param>
    /// <param name="offset">Specifying the amount of excluded from a response the first N orders</param>
    /// <param name="count">Specifying the limit of orders for the request</param>
    /// <param name="cancellationToken"></param>
    /// <returns>GetOrderListResponse</returns>
    public static Task<IResponse<GetOrderListResponse>> GetOrderListAsync(
        this IWalletPayClient walletPayClient,
        int offset,
        int count,
        CancellationToken cancellationToken = default)
        => walletPayClient.MakeRequestAsync(
            request: new GetOrderListRequest(offset, count),
            cancellationToken: cancellationToken);

    /// <summary>
    /// Returns total count of all created orders in the Store, including all - paid and unpaid
    /// </summary>
    /// <param name="walletPayClient"></param>
    /// <param name="cancellationToken"></param>
    /// <returns>GetOrderAmountResponse</returns>
    public static Task<IResponse<GetOrderAmountResponse>> GetOrderAmountAsync(
        this IWalletPayClient walletPayClient,
        CancellationToken cancellationToken = default)
        => walletPayClient.MakeRequestAsync(
            request: new GetOrderAmountRequest(),
            cancellationToken: cancellationToken);
}
