using MassTransit;
using Microsoft.Extensions.Options;
using Shared.Common.Options;

namespace OrderApi;

public static class DependencyInjection
{
    public static IServiceCollection AddOrderApi(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddOptionModels(configuration)
            .AddMessageBroker();
        return services;
    }
    
    private static IServiceCollection AddOptionModels(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<AppSettingModel>(configuration.GetSection(AppSettingModel.SectionName));
        
        return services;
    }
    
    private static IServiceCollection AddMessageBroker(this IServiceCollection services)
    {
        var appSetting = services.BuildServiceProvider().GetRequiredService<IOptions<AppSettingModel>>().Value;
        services.AddMassTransit(opt =>
        {
            opt.UsingRabbitMq((_, cfg) =>
            {
                cfg.Host(appSetting.RabbitMqConnectionString);
            });
        });
        return services;
    }
}