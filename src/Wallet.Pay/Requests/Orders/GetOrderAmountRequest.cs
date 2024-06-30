namespace Wallet.Pay.Requests.Orders;

internal class GetOrderAmountRequest() 
    : Request<OrderAmountResponse>(
        "wpay/store-api/v1/reconciliation/order-amount");
