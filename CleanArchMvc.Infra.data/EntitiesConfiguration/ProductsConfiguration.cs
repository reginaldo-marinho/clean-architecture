using Microsoft.EntityFrameworkCore;
using CleanArchMvc.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ProductsConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {

    }
}