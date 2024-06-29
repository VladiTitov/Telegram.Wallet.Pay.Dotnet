namespace Wallet.Pay.Requests.Orders;

internal class GetOrderAmountRequest() 
    : RequestBase<OrderAmountResponse>(
        uriPath: "wpay/store-api/v1/reconciliation/order-amount", 
        method: HttpMethod.Get);
