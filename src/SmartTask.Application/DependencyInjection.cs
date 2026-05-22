
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace SmartTask.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            // MediatR
            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly);
            });

            // FluentValidation
            //services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

            // Pipeline Behaviors
            //services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

            return services;
        }
    }
}