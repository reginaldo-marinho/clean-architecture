using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using CleanArchMvc.Domain;
using CleanArchMvc.Domain.Context;
using CleanArchMvc.Domain.Repositories;

namespace CleanArchMvc.infra.Ioc;

public static class DependencyInjection
{
    public  static IServiceCollection  AddInfratructureEfStartup (this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>( options => 
            options.UseNpgsql(configuration.GetConnectionString("UdemyServer")
            , b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));
         
        services.AddScoped<ICategoryRepository,CategoryRepository>();
        services.AddScoped<IProductRepository,ProductRepository>();
        
        services.AddScoped<IProductServices,ProductServices>();
        services.AddScoped<ICategoryServices,CategoryServices>();

        services.AddAutoMapper(typeof(DomainToDTOMappingProfile));
        return services;
    }
    
}