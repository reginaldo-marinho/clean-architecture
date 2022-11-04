using Microsoft.EntityFrameworkCore;
using CleanArchMvc.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder
            .HasKey(p => p.Id)
            .HasName("PrimaryKey_ProductId");
        builder
            .Property( p => p.Name)
            .HasMaxLength(100)
            .IsRequired();
    }
}