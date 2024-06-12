namespace Wallet.Pay;

public interface IWalletPayClient
{
    Task<ResponseBase<TResponse>?> MakeRequestAsync<TResponse>(
        IRequest<TResponse> request,
        CancellationToken cancellationToken = default) where TResponse : class;
}
