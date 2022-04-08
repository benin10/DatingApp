using System;
using API.Data;
using API.Interfaces;
using API.Services;
using Microsoft.EntityFrameworkCore;

namespace API.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServicees(this IServiceCollection services, IConfiguration config)
        {
             services.AddScoped<ITokenService,TokenService>();
            services.AddDbContext<DataContext>(option =>
            {
                option.UseSqlite(config.GetConnectionString("DefaultConnection"));

            });
            return services;
        }
    }
}
