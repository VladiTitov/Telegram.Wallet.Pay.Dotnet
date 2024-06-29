namespace Wallet.Pay.Requests.Orders;

internal class GetOrderListRequest(int offset, int count) 
    : RequestBase<GetOrderReconciliationListResponse>(
        uriPath: $"wpay/store-api/v1/reconciliation/order-list?offset={offset}&count={count}",
        method: HttpMethod.Get);
