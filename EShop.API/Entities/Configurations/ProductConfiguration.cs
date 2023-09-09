using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EShop.API.Entities.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.Property(prop => prop.Name)
            .HasMaxLength(255);

        builder.Property(prop => prop.Stock)
            .HasDefaultValue(0);

        builder.HasIndex(prop => prop.Name);
        builder.HasIndex(prop => prop.Stock);
    }
}
