using Wallet.Pay.Responses.Orders;

namespace Wallet.Pay.Requests.Orders;

internal class GetOrderAmountRequest() 
    : RequestBase<GetOrderAmountResponse>(
        "wpay/store-api/v1/reconciliation/order-amount", 
        HttpMethod.Get)
{
}
