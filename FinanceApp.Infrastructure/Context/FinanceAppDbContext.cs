using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace FinanceApp.Infrastructure.Context;

public class FinanceAppDbContext : DbContext
{
    public FinanceAppDbContext(DbContextOptions<FinanceAppDbContext> options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)   
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            var connectionString = configuration.GetConnectionString("ConnectionTest");

            if (string.IsNullOrEmpty(connectionString))
                throw new InvalidOperationException("Conexão vazia");

            optionsBuilder.UseSqlServer(connectionString);
        }
    }

    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        base.ConfigureConventions(configurationBuilder);
    }
}
