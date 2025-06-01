using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryProj.Infrastructure.ServiceExtension
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddDIServices(this IServiceCollection services , IConfiguration configuration)
        {
            services.AddDbContext<InventoryDataContext>(opt =>
            {
                opt.UseSqlServer(configuration.GetConnectionString("Inv"));
            });
            return services;
        }
    }
}
