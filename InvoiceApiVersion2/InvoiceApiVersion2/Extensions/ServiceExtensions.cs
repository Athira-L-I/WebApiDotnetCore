//using AutoMapper;
using BusinessServices;
using Contracts;
using Contracts.BusinessServices;
using Contracts.DataServices;
using LoggerService;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repository.Context;
using Repository.DataServices;

namespace InvoiceApiVersion2.Extensions
{
    public static class ServiceExtensions
    {
        // Injecting Business and Data Services
        public static void ConfigureInvoiceServices(this IServiceCollection services)
        {
            services.AddScoped<IInvoiceService, InvoiceService>();
            services.AddScoped<IInvoiceDataService, InvoiceDataService>();
            services.AddScoped<IParameterDataService, ParameterDataService>();
        }

        // configuring database connectivity
        public static void ConfigureSqlServerContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config["ConnectionString:InvoiceDB"];
            services.AddDbContext<InvoiceDbContext>(
                options =>
                    options.UseSqlServer(connectionString)
                    );
        }

        // configuring CORS
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials());
            });
        }

        // configuring logging

        public static void ConfigureLoggerService(this IServiceCollection services)
        {
            services.AddSingleton<ILoggerManager, LoggerManager>();

            // create the service the first time you request it 
            //and then every subsequent request calls the same instance of the service
        }

        //configuring automapper
        // https://sensibledev.com/asp-net-core-automapper/
        //public static void ConfigureAutoMapper(this IServiceCollection services)
        //{
        //    services.AddAutoMapper();

        //}


        // configuring IIS integration
        //public static void ConfigureIISIntegration(this IServiceCollection services)
        //{
        //    services.Configure<IISOptions>(options =>
        //    {

        //    });
        //}
    }
}
