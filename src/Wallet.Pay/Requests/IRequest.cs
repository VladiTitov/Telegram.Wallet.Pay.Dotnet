namespace Wallet.Pay.Requests;

public interface IRequest<TResponse>
{
    HttpMethod Method { get; }
    string UriPath { get; }
    HttpContent? ToHttpContent();
}
