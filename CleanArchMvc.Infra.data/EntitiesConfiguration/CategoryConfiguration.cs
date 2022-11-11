using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchMvc.Domain.EntitiesConfiguration;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder
            .HasKey(p => p.Id)
            .HasName("PrimaryKey_CategoryId");
        builder
            .Property( p => p.Name)
            .HasMaxLength(100)
            .IsRequired();
    }
}