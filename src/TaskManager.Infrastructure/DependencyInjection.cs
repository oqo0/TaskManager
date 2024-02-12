using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Infrastructure.Data;

namespace TaskManager.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            #region Add db context

            var dbConnectionString = configuration.GetConnectionString("AppDb");

            if (string.IsNullOrEmpty(dbConnectionString))
            {
                throw new ArgumentNullException(nameof(configuration),
                    "Db connection string in configuration can't be null or empty");
            }

            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseNpgsql(dbConnectionString);
            });

            #endregion

            return services;
        }
    }
}
