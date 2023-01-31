
namespace DUKKANTEK.Inventory.Infrastructure;
public static class InfrastructureServiceRegistration
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<InventoryDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("ConnectionString")));

        InventorySeedData(services);

        services.AddScoped(typeof(IAsyncRepository<>), typeof(RepositoryBase<>));
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<IBasketRepository, BasketRepository>();

        return services;
    }

    public static IServiceCollection InventorySeedData(this IServiceCollection services)
    {

        var serviceProvider = services.BuildServiceProvider();

        using (var scope = serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope())
        {
            var applicationDbContext = scope.ServiceProvider.GetService<InventoryDbContext>();
            applicationDbContext?.Database.Migrate();

            InventoryContextSeed.SeedAsync(applicationDbContext).Wait();
        }
        return services;
    }

}
