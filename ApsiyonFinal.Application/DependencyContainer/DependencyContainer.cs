using Apsiyon.Domain.Interface;
using Apsiyon.Domain.Model;
using Apsiyon.Infrastructure.Context;
using Apsiyon.Infrastructure.Repositories;
using Apsiyon.Infrastructure.UnitofWork;
using ApsiyonFinal.Application.Interfaces;
using ApsiyonFinal.Application.Profiles;
using ApsiyonFinal.Application.Services;
using AutoMapper;
using AutoMapper.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ApsiyonFinal.Application.DependencyContainer
{

    public static class DependencyContainer
    {
        public static IServiceCollection RegisterApsiyon(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApsiyonContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("Default"))
            .UseLazyLoadingProxies());

            services.AddDefaultIdentity<User>(options => options.SignIn.RequireConfirmedAccount = true)
           .AddEntityFrameworkStores<ApsiyonContext>();

            services.AddScoped<IUnitofWork, UnitofWork>();
            services.AddScoped<IApartmentService, ApartmentService>();
            services.AddScoped<IApartmentRepository, ApartmentRepository>();
            services.AddScoped<IBuildingService, BuildingService>();
            services.AddScoped<IBuildingRepository, BuildingRepository>();
            services.AddScoped<IIncomeExpenseService, IIncomeService>();
            services.AddScoped<IIncomeExpenseRepository, IncomeExpenseRepository>();

            services.AddHttpClient<ICreditCardService, CreditCardService>(options => {
                options.BaseAddress = new Uri(configuration["CreditCard:Url"]);
            });


            var mappingConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddExpressionMapping();
                cfg.AddProfile(new ApartmentProfile());
                cfg.AddProfile(new BuildingProfile());
                cfg.AddProfile(new IncomeExpenseProfile());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
