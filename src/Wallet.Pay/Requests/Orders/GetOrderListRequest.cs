using Wallet.Pay.Responses.Orders;

namespace Wallet.Pay.Requests.Orders;

internal class GetOrderListRequest(int offset, int count) 
    : RequestBase<GetOrderListResponse>(
        $"wpay/store-api/v1/reconciliation/order-list?offset={offset}&count={count}",
        HttpMethod.Get)
{
}
