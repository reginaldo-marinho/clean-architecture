using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using CleanArchMvc.Domain.Context;


namespace CleanArchMvc.infra.Ioc;
using CleanArchMvc.Domain;
using CleanArchMvc.Domain.Context;
using CleanArchMvc.Domain.Repositories;

public static class DependencyInjection
{
    public  static IServiceCollection  AddInfratructureEfStartup (this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>( options => 
        options.UseNpgsql(configuration.GetConnectionString("UdemyServer")
        , b=> b.MigrationsAssembly(typeof(ApplicationDbContext).FullName)));
         
         services.AddScoped<ICategoryRepository,CategoryRepository>();
         services.AddScoped<IProductRepository,ProductRepository>();

        return services;
    }
}