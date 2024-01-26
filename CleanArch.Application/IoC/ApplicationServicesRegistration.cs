using System.Reflection;
using FluentValidation;
using CleanArch.Application.Behaviors;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArch.Application.IoC;

public static class ApplicationServicesRegistration
{
	public static IServiceCollection AddApplicationServices(this IServiceCollection services)
	{
		services.AddMediatR(config =>
			config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

		services.AddAutoMapper(Assembly.GetExecutingAssembly());

		services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

		services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

		return services;
	}
}