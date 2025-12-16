using Ecommerce.Application.Contracts.Infraestructure;
using Ecommerce.Application.Extensions;
using Ecommerce.Infrastructure.MessageImplementation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace Ecommerce.Infrastructure;

 public static class ApplicationServiceRegistration
{
 public static IServiceCollection AddAInfraestructureServices(
                this IServiceCollection services,
                IConfiguration configuration
 )
    {
        services.AddTransient<IEmailService, EmailService>();
        return services;
    }
}