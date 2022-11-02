using Microsoft.EntityFrameworkCore;
using CleanArchMvc.Domain;

public class AplicationDbContext :DbContext 
{
    public AplicationDbContext(DbContextOptions<AplicationDbContext> options)
        :base(options){
    }
    public DbSet<Category> Categories {get;set;}
    public DbSet<Product> Products {get;set;}
    protected override void OnModelCreating(ModelBuilder builder){
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(typeof(AplicationDbContext).Assembly);
    }
}