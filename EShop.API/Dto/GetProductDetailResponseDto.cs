namespace EShop.API.Dto;

public record GetProductDetailResponseDto
{
    public Guid Id { get; set; }

    public required string Name { get; set; }

    public int Stock { get; set; }
}
