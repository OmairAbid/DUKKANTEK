

namespace DUKKANTEK.Inventory.Domain.Entities;
public class Products : EntityBase
{
    public string? Name { get; set; }
    public string? Barcode { get; set; }
    public string? Description { get; set; }
    public string? CategoryName { get; set; }
    public bool IsWeighted { get; set; }
    public int ProductStatus { get; set; }

    public virtual ICollection<Baskets> Baskets { get; set; }
}
