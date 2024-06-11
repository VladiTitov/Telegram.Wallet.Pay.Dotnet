using System.Net;

namespace Wallet.Pay.Exceptions;

public class RequestException : Exception
{
    public HttpStatusCode HttpStatusCode { get; }

    public RequestException(string message) 
        : base(message)
    { }

    public RequestException(string message, Exception exception) 
        : base(message, exception)
    { }

    public RequestException(string message, HttpStatusCode httpStatusCode) 
        : base(message)
    {
        HttpStatusCode = httpStatusCode;
    }

    public RequestException(string message, HttpStatusCode httpStatusCode, Exception innerException) 
        : base(message, innerException)
    {
        HttpStatusCode = httpStatusCode;
    }
}
