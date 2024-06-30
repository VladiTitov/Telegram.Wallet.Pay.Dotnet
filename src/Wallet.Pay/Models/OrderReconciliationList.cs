namespace Wallet.Pay.Models;

#nullable disable
public class OrderReconciliationList
{
    /// <summary>
    /// <see cref="OrderReconciliationItem"/>
    /// </summary>
    public IEnumerable<OrderReconciliationItem> Items { get; set; }
}
