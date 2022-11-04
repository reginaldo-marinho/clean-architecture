using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using CleanArchMvc.Domain;
public static class DependencyInjection
{
    public  static IServiceCollection  AddInfratructure ( this  IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AplicationDbContext>( options => 
        options.UseSqlServer(configuration.GetConnectionString("UdemyServer")
        , b=> b.MigrationsAssembly(typeof(AplicationDbContext).FullName)));
         
         services.AddScoped<ICategoryRepository,CategoryRepository>();
         services.AddScoped<IProductRepository,ProductRepository>();

        return services;
    }
}