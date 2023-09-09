using EShop.API.Constant;
using EShop.API.Context;
using EShop.API.Services.v1;
using EShop.API.Services.v1.Interface;
using FastEndpoints;
using Microsoft.OpenApi.Models;

namespace EShop.API.DI;

public static class DependencyInjection
{
    public static void AddCustomSQLServerConnection(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSqlServer<EShopDbContext>(connectionString:
            configuration.GetConnectionString(CommonConstant.EShopConnectionString));
    }

    public static void AddRegisterProductServiceDI(this IServiceCollection services)
    {
        services.AddScoped<IHomePageService, HomePageService>();
    }

    public static void AddCustomFastEndpoint(this IServiceCollection services)
    {
        services.AddFastEndpoints(options =>
        {
            options.IncludeAbstractValidators = true;
        });
    }

    public static void AddCustomSwagger(this IServiceCollection services)
    {
        services.AddSwaggerGen(options =>
        {
            options.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "Minimal API.",
                Description = "Minimal API Description.",
                Contact = new OpenApiContact
                {
                    Email = "tamle.dev@gmail.com",
                    Name = "060286",
                    Url = new Uri("https://github.com/060286") // Replace by your url.
                },
            });
        });
    }
}
