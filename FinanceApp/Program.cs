using FinanceApp.Configuration;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using Serilog;

namespace FinanceApp;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        // Inicializa configuração do Windows Forms (tema, DPI, etc.)
        ApplicationConfiguration.Initialize();

        // Cria a configuração a partir do appsettings.json
        var configuration = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .Build();

        // Configura Serilog
        Log.Logger = new LoggerConfiguration()
            .ReadFrom.Configuration(configuration)
            .Enrich.FromLogContext()
            .CreateLogger();

        try
        {
            Log.Information("Iniciando aplicação...");

            // Cria o host
            var host = CreateHostBuilder(configuration).Build();

            // Resolve o FormPrincipal via DI
            var formPrincipal = host.Services.GetRequiredService<FormPrincipal>();

            // Executa o form principal
            System.Windows.Forms.Application.Run(formPrincipal);

        }
        catch (Exception ex)
        {
            Log.Fatal(ex, "Erro ao iniciar a aplicação");
        }
        finally
        {
            Log.CloseAndFlush();
        }
    }

    private static IHostBuilder CreateHostBuilder(IConfiguration configuration) =>
        Host.CreateDefaultBuilder()
            .UseSerilog() // Ativa Serilog
            .ConfigureServices((hostContext, services) =>
            {
                // Adiciona todos os serviços e forms
                services.AddDependencyInjection(configuration);
            });
}
