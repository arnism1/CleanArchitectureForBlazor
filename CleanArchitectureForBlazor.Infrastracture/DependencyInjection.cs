using CleanArchitectureForBlazor.Application.Repositories;
using CleanArchitectureForBlazor.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitectureForBlazor.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            // Registering the DbContext
            services.AddDbContext<ApplicationDbContext>((serviceProvider, options) =>
            {
                // Retrieve the configuration from the service provider
                var configuration = serviceProvider.GetRequiredService<IConfiguration>();
                var connectionString = configuration.GetConnectionString("DefaultConnection");

                // Configure DbContext with the connection string
                options.UseSqlServer(connectionString);
            });

            services.AddScoped<IMovieRepository, MovieRepository>();

            return services;
        }
    }
}