using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public static class ServiceExtensions
    {
        public static void AddRepository(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        }

        public static void AddDbContext(this IServiceCollection services, string connStr)
        {
            services.AddDbContext<CarDbContext>(opt => opt.UseSqlServer(connStr));
        }
        public static void AddIdentity(this IServiceCollection services)
        {
            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<CarDbContext>()
                .AddDefaultTokenProviders();
        }
    }
}
