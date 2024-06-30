namespace Wallet.Pay.Requests.Orders;

internal class GetOrderListRequest(int offset, int count) 
    : Request<GetOrderReconciliationListResponse>(
        $"wpay/store-api/v1/reconciliation/order-list?offset={offset}&count={count}");
