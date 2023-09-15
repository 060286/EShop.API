using EShop.API.Base;

namespace EShop.API.Entities;

public class Product : BaseEntity, IKey<Guid>
{
    public Guid Id { get; set; }

    public required string Name { get; set; }

    public int Stock { get; set; }

    public Guid CategoryId { get; set; }

    public virtual ProductCategory? ProductCategory { get; set; }
}
