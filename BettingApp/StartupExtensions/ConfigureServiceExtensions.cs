using BettingApp.Entities;
using BettingApp.Repository;
using BettingApp.RepositoryContracts;
using BettingApp.ServiceContracts;
using BettingApp.Services;
using Microsoft.EntityFrameworkCore;

namespace BettingApp.StartupExtensions
{
    public static class ConfigureServiceExtensions
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BettingDbContext>(options =>
           options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            using (var serviceProvider = services.BuildServiceProvider())
            {
                var dbContext = serviceProvider.GetRequiredService<BettingDbContext>();
                if (dbContext.Database.GetPendingMigrations().Any())
                {
                    dbContext.Database.Migrate();
                }
            }


            #region IOC

            services.AddScoped<IBettingService, BettingService>();
            services.AddScoped<IBettingDataRepository, BettingDataRepository>();

            #endregion

            services.AddControllers();

            return services;
        }
    }
}
