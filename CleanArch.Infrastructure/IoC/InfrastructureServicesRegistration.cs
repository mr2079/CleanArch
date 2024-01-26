using CleanArch.Application.Contracts.Persistence;
using CleanArch.Infrastructure.Implementation.Repositories;
using CleanArch.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArch.Infrastructure.IoC;

public static class InfrastructureServicesRegistration
{
	public static IServiceCollection AddInfrastructureServices(
		this IServiceCollection services,
		IConfiguration configuration)
	{
		services.AddDbContext<ApplicationContext>(options =>
		{
			options.UseSqlServer(configuration.GetSection("Databases:SqlServer:ConnectionString").Value);
		});

		services.AddScoped(typeof(IQueryRepository<,>), typeof(QueryRepository<,>));
		services.AddScoped(typeof(ICommandRepository<,>), typeof(Repository<,>));

		return services;
	}
}