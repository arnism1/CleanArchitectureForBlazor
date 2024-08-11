using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Microsoft.EntityFrameworkCore;


namespace CleanArchitectureForBlazor.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services) {

            services.AddDbContext()

                   builder.Services.AddDbContext<Fancy.Infrastructure.Persistence.ApplicationDbContext>(options =>
                   {
                       options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
                   });

            return services;
        }

        
    }
}
