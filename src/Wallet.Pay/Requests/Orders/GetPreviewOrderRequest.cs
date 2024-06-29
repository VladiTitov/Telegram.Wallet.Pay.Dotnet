namespace Wallet.Pay.Requests.Orders;

internal class GetPreviewOrderRequest(string id) 
    : RequestBase<GetOrderPreviewResponse>(
        uriPath: $"wpay/store-api/v1/order/preview?id={id}",
        method: HttpMethod.Get);
