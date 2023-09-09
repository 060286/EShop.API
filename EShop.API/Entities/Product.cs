namespace EShop.API.Entities;

public class Product
{
    public Guid Id { get; set; }

    public required string Name { get; set; }

    public int Stock { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public Guid CategoryId { get; set; }

    public virtual ProductCategory? ProductCategory { get; set; }
}
