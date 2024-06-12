using Wallet.Pay.Enums;
using Wallet.Pay.Requests.Orders;

namespace Wallet.Pay.Tests.Integrations.OrderRequests;

public class OrderRequestsScenarios : BaseClientScenarios
{
    private readonly DataGeneratorHelper _dataGeneratorHelper = new();

    [Fact]
    public async Task CreateOrderRequests_GetAlreadyStatus()
    {
        //Arrange
        var request = _dataGeneratorHelper.GetCreateOrderRequest();

        //Act
        var response = await _walletPayClient.MakeRequestAsync(request);

        //Assert
        Assert.NotNull(response);
        Assert.True(response.Status == ResponseStatus.ALREADY || response.Status == ResponseStatus.SUCCESS);
    }

    [Fact]
    public async Task CreateOrderRequests_GetPreviewOrder_GetSuccessStatus()
    {
        //Arrange
        var createOrderRequest = _dataGeneratorHelper.GetCreateOrderRequest();

        //Act
        var createOrderResponse = await _walletPayClient.MakeRequestAsync(createOrderRequest);
        var getPreviewOrderResponse = await _walletPayClient.MakeRequestAsync(
            request: new GetPreviewOrderRequest(createOrderResponse.Data.Id));

        //Assert
        Assert.NotNull(createOrderResponse);
        Assert.True(createOrderResponse.Status == ResponseStatus.ALREADY || createOrderResponse.Status == ResponseStatus.SUCCESS);

        Assert.NotNull(getPreviewOrderResponse);
        Assert.Equal(ResponseStatus.SUCCESS, getPreviewOrderResponse.Status);
    }

    [Fact]
    public async Task GetOrderAmountResponse_GetSuccessStatus()
    {
        //Arrange
        var request = new GetOrderAmountRequest();

        //Act
        var response = await _walletPayClient.MakeRequestAsync(request);

        //Assert
        Assert.NotNull(response);
        Assert.Equal(ResponseStatus.SUCCESS, response.Status);
    }

    [Fact]
    public async Task GetOrderListResponse_GetSuccessStatus()
    {
        //Arrange
        var request = new GetOrderListRequest(5, 10);

        //Act
        var response = await _walletPayClient.MakeRequestAsync(request);

        //Assert
        Assert.NotNull(response);
        Assert.Equal(ResponseStatus.SUCCESS, response.Status);
    }
}
