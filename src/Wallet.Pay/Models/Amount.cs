namespace Wallet.Pay.Models;

#nullable disable
public class Amount
{
    [JsonProperty("amount")]
    public string Value { get; set; }
    public Currency CurrencyCode { get; set; }
}
