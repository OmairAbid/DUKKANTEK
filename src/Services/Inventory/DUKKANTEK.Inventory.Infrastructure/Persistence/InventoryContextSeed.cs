
namespace DUKKANTEK.Inventory.Infrastructure.Persistence;
public static class InventoryContextSeed
{
    public static async Task SeedAsync(InventoryDbContext dbContext)
    {
        if (!dbContext.Products.Any())
        {
            dbContext.Products.AddRange(GetPreconfiguredOrders());
            await dbContext.SaveChangesAsync();
        }
    }

    private static IEnumerable<Products> GetPreconfiguredOrders()
    {
        return new List<Products>
            {
                new Products() { Name = "Shirt", Barcode = "000000017" , CategoryName = "Fashion", IsWeighted = false, ProductStatus = (int)ProductStatus.inStock, Description = "wearables garments" },
                new Products() { Name = "Jeans", Barcode = "000000018" , CategoryName = "Fashion", IsWeighted = false, ProductStatus = (int)ProductStatus.Damaged, Description = "wearables garments" },
                new Products() { Name = "Plant", Barcode = "000000019" , CategoryName = "Home and Garden", IsWeighted = false, ProductStatus = (int)ProductStatus.Sold, Description = "wearables garments" },
                new Products() { Name = "Football", Barcode = "000000010" , CategoryName = "Sporting Goods", IsWeighted = false, ProductStatus = (int)ProductStatus.inStock, Description = "wearables garments" },
                new Products() { Name = "Face wash", Barcode = "000000011" , CategoryName = "Health and Wellness", IsWeighted = false, ProductStatus = (int)ProductStatus.Sold, Description = "wearables garments" }
            };
    }
}
