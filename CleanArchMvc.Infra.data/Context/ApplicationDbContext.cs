using Microsoft.EntityFrameworkCore;
using CleanArchMvc.Domain;

namespace CleanArchMvc.Domain.Context;
public class ApplicationDbContext : DbContext 
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options){}
    public DbSet<Category> Categories {get;set;}
    public DbSet<Product> Products {get;set;}
    protected override void OnModelCreating(ModelBuilder builder){
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }
}