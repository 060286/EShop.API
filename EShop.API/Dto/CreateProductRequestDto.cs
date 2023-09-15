namespace EShop.API.Dto;

public record CreateProductRequestDto
{
    public required string Name { get; set; }

    public int Stock { get; set; }

    public Guid CategoryId { get; set; }
}
