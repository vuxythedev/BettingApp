using BettingApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BettingApp.StartupExtensions
{
    public static class ConfigureServiceExtensions
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BettingDbContext>(options =>
           options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

           
            #region IOC

            #endregion

            return services;
        }
    }
}
