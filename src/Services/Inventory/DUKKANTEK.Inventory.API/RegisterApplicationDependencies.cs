
namespace DUKKANTEK.Inventory.API;

public static class RegisterApplicationDependencies
{
    public static void AddApplicationDependencies(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddApplicationServices();
        services.AddInfrastructureServices(configuration);
    }
}
