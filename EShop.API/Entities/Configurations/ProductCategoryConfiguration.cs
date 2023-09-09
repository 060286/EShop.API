using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EShop.API.Entities.Configurations;

public class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
{
    public void Configure(EntityTypeBuilder<ProductCategory> builder)
    {
        builder.Property(prop => prop.Name)
            .HasMaxLength(255);

        builder.HasMany(many => many.Products)
            .WithOne(one => one.ProductCategory)
            .HasForeignKey(key => key.CategoryId);

        builder.HasIndex(prop => prop.Name);
    }
}
