namespace Wallet.Pay;

#nullable disable
public class WalletPayClientOptions(string token)
{
    internal readonly string BaseWalletPayUri = "https://pay.wallet.tg";
    public string Token { get; } = token;
}
