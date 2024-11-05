using Microsoft.EntityFrameworkCore;
using Vacancies.DataAccess;

namespace vacancies.Service.IoC;

public class DbContextConfigurator
{
    public static void ConfigureServices(WebApplicationBuilder builder)
    {
        var configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", false)
            .Build();
        var connectionString = configuration.GetValue<string>("VacanciesDbContext");
        builder.Services.AddDbContextFactory<VacanciesDbContext>(
            options => { options.UseNpgsql(connectionString); },
            ServiceLifetime.Scoped);
    }

    public static void ConfigureApplication(IApplicationBuilder app)
    {
        using var scope = app.ApplicationServices.CreateScope();
        var contextFactory = scope.ServiceProvider.GetRequiredService<IDbContextFactory<VacanciesDbContext>>();
        using var context = contextFactory.CreateDbContext();
        context.Database.Migrate();
    }
}