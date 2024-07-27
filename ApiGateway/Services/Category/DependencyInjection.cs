using Category.Services.Implementations;
using Category.Services.Interfaces;

namespace Category;

public static class DependencyInjection
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<ICategoryService, CategoryService>();
        return services;
    }
}