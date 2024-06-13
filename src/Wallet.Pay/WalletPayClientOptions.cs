namespace Wallet.Pay;

/// <summary>
/// This class is used to provide configuration for <see cref="WalletPayClient"/>
/// </summary>
/// <param name="token">Wallet Pay API token</param>
#nullable disable
public class WalletPayClientOptions(string token)
{
    internal readonly string BaseWalletPayUri = "https://pay.wallet.tg";

    /// <summary>
    /// Wallet Pay API token
    /// </summary>
    public string Token { get; } = token;
}
