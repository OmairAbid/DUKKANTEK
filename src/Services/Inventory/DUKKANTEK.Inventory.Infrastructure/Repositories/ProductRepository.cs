

namespace DUKKANTEK.Inventory.Infrastructure.Repositories;
public class ProductRepository : RepositoryBase<Products>, IProductRepository
{
    public ProductRepository(InventoryDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<Dictionary<ProductStatus, int>> GetProductsByStatusCount()
    {
       var query = _dbContext.Products.GroupBy(g => g.ProductStatus).Select(s => new
        {
            ProductStatus = s.Key,
           Count = s.Count()
       });

        var result = query.ToDictionary(k => (ProductStatus)k.ProductStatus, i => i.Count);

        return result;
    }
}
