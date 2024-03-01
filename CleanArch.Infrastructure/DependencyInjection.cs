using CleanArch.Application.Contracts.Persistence;
using CleanArch.Application.Model.SiteSettings;
using CleanArch.Infrastructure.Implementation.Repositories;
using CleanArch.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace CleanArch.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(
        this IServiceCollection services)
    {
        var siteSettings = services.BuildServiceProvider()
            .GetRequiredService<IOptionsSnapshot<SiteSetting>>().Value;

        services.AddDbContext<SqlServerContext>(options =>
        {
            options.UseSqlServer(siteSettings.Database.SqlServer.ConnectionString);
        });

        services.AddSingleton(_ => 
            new MongoDbContext(siteSettings.Database.MongoDb.ConnectionString,
                siteSettings.Database.MongoDb.DatabaseName));

        services.AddScoped(typeof(IQueryRepository<,>), typeof(QueryRepository<,>));
        services.AddScoped(typeof(ICommandRepository<,>), typeof(Repository<,>));

        return services;
    }
}