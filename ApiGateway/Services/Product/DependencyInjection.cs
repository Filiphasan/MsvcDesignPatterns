using Product.Services.Implementations;
using Product.Services.Interfaces;

namespace Product;

public static class DependencyInjection
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<IProductService, ProductService>();
        return services;
    }
}