
namespace DUKKANTEK.Inventory.Infrastructure.Repositories;
internal class BasketRepository : RepositoryBase<Baskets>, IBasketRepository
{
    public BasketRepository(InventoryDbContext dbContext) : base(dbContext)
    {
    }
}
