

namespace DUKKANTEK.Inventory.Infrastructure.Persistence.EntityConfiguration;
public class BascketConfiguration : IEntityTypeConfiguration<Baskets>
{
    public void Configure(EntityTypeBuilder<Baskets> builder)
    {
        builder.HasOne<Products>()
            .WithMany(parent => parent.Baskets)
            .HasForeignKey(me => me.ProductId);
    }
}
