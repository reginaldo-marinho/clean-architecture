using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchMvc.Domain.EntitiesConfiguration;

public class ProductsConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(p => p.Id).HasName("PrimaryKey_ProductId");
        builder.Property( p => p.Name).HasMaxLength(100).IsRequired();
        builder.Property( p => p.Descrition).HasMaxLength(200).IsRequired();
        builder.Property( p => p.Price).HasPrecision(10,2);
        builder.HasOne(c => c.Category).WithMany( p => p.Products).HasForeignKey(p => p.Id).HasPrincipalKey(b => b.Id);
    }
}