using Ecommerce.Application.Models.Token;
using Ecommerce.Application.Persistence;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ecommerce.Infraestructure.Repositories;

public static class InfraestructureServiceRegistration
{
    public static IServiceCollection AddInfraestructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped(typeof(IAsyncRepository<>), typeof(RepositoryBase<>));

        services.Configure<JwtSettings>(configuration.GetSection("JwtSettings"));


        return services;
    }
}