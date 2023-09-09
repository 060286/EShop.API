namespace EShop.API.Entities;

public class ProductCategory
{
    public Guid Id { get; set; }

    public required string Name { get; set; }

    public required string CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual IList<Product>? Products { get; set; }
}
