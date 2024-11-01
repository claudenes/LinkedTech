using Avaliacao.Application.Interfaces;
using Avaliacao.Application.Mappings;
using Avaliacao.Application.Services;
using Avaliacao.Domain.Interfaces;
using Avaliacao.Infra.Data.Context;
using Avaliacao.Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Avaliacao.Infra.IoC
{
    public static class DependencyInjection
    {
       
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            ConfigureEntityFrameWork(services);
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddAutoMapper(typeof(DomainToDtoMappingProfile));

            var myhandlers = AppDomain.CurrentDomain.Load("DesafioTJ.Application");

            return services;
        }
        private static void ConfigureEntityFrameWork(this  IServiceCollection services)
        {
            string connectionString = "";

            connectionString = @"Data Source=DESKTOP-OAG94LR\SQLEXPRESS;Initial Catalog=AVALIACAO;Integrated Security=True;";

            services.AddDbContext<ApplicationDbContext>(options =>
            {

                options.UseSqlServer(connectionString,
                    b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)); options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            });

        }
        public static IServiceCollection AddServices(this IServiceCollection services) 
        {
            
            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<IEnderecoService, EnderecoService>();
           
            services.AddAutoMapper(typeof(DomainToDtoMappingProfile));
            return services;
        }
    }
    
}
