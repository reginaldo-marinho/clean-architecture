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
        builder
            .HasOne(c => c.Category)
            .WithMany( p => p.Products)
            .HasForeignKey(p => p.CategoryId)
            .HasPrincipalKey(c => c.Id);
        
        builder.HasData(new Product(1,"Coca Cola","Refrigerante Coca Cola 200ml",4.77m,"",1));
        builder.HasData(new Product(2,"Pepsi","Refrigerante Pepsi 200ml",3.8m,"",1));
        builder.HasData(new Product(3,"Fanta Laranja","Refrigerante Fanta Laranja 200ml",4.77m,"",1));
        builder.HasData(new Product(4,"Coxinha","Coxinha 50g",5m,"",2));
        builder.HasData(new Product(5,"Kibe","Kibe 100g",4.40m,"",2));
    }
}