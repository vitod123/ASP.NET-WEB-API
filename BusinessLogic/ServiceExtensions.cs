using Core.Interfaces;
using Core.Service;
using Core.Services;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public static class ServiceExtensions
    {
        public static void AddAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }

        public static void AddCustomServices(this IServiceCollection services)
        {
            services.AddScoped<ICarsService, CarsService>();
            services.AddScoped<IMakesService, MakesService>();
            services.AddScoped<IModelsService, ModelsService>();
            services.AddScoped<IYearsService, YearsService>();
            services.AddScoped<IEnginesService, EnginesService>();
            services.AddScoped<IAccountsService, AccountsService>();
            services.AddScoped<IJwtService, JwtService>();
        }
        public static void AddValidators(this IServiceCollection services)
        {
            services.AddFluentValidationAutoValidation();
            services.AddValidatorsFromAssemblies(AppDomain.CurrentDomain.GetAssemblies());
        }
    }
}
