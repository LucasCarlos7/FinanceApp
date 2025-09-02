using FinanceApp.Application.Services;
using FinanceApp.Core.Interfaces.Repositories;
using FinanceApp.Core.Interfaces.Services;
using FinanceApp.Infrastructure.Context;
using FinanceApp.Infrastructure.Repositories;
using FinanceApp.WinForms;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FinanceApp.Configuration;

public static class DependecyInjectionConfiguration
{
    public static IServiceCollection AddDependencyInjection
    (
        this IServiceCollection services,
        IConfiguration configuration
    )
    {
        services.AddDbContext<FinanceAppDbContext>();
        services.AddTransient<FormPrincipal>();
        services.AddTransient<FormCriarMembros>();

        services.AddScoped<IMembrosRepository, MembrosRepository>();
        services.AddScoped<IMembrosService, MembrosService>();

        services.AddSingleton(configuration);

        return services;
    }
}

