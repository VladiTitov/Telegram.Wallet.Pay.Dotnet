using System.Globalization;

namespace Wallet.Pay.Models;

/// <summary>
/// Amount model
/// </summary>
#nullable disable
public class Amount
{
    public Amount()
    { }

    public Amount(double value, Currency currencyCode)
    {
        Value = string.Format(CultureInfo.InvariantCulture, "{0}", value);
        CurrencyCode = currencyCode;
    }

    /// <summary>
    /// Big decimal string representation. 
    /// Note that the max precision (number of digits after decimal point) depends on the currencyCode. 
    /// E.g. for all fiat currencies is 2 (0.01), for TON is 9, for BTC is 8, for USDT is 6. 
    /// There's also min order amount for creating an order. 
    /// It's 0.001 TON / 0.000001 BTC / 0.01 USDT / 0.01 USD / 0.01 EUR / 0.1 RUB.
    /// </summary>
    [JsonProperty("amount")]
    public string Value { get; set; }

    /// <summary>
    /// Currency code
    /// </summary>
    public Currency CurrencyCode { get; set; }
}
