using Wallet.Pay.Responses.Orders;

namespace Wallet.Pay.Requests.Orders;

internal class GetPreviewOrderRequest(string id) 
    : RequestBase<GetPreviewOrderResponse>(
        $"wpay/store-api/v1/order/preview?id={id}",
        HttpMethod.Get)
{
}
