
namespace DUKKANTEK.Inventory.Domain.Entities;
public class Baskets:EntityBase
{
    public string BillingAddress { get; set; }
    public string ShippingAddress { get; set; }
    public int ProductId { get; set; }
}
