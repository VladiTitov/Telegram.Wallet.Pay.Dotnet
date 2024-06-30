namespace Wallet.Pay.Requests.Orders;

internal class GetPreviewOrderRequest(string id) 
    : Request<GetOrderPreviewResponse>(
        $"wpay/store-api/v1/order/preview?id={id}");
