using EShop.API.Base;

namespace EShop.API.Entities;

public class ProductCategory : BaseEntity, IKey<Guid>
{
    public Guid Id { get; set; }

    public required string Name { get; set; }

    public virtual IList<Product>? Products { get; set; }
}
