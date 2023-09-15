namespace EShop.API.Dto
{
    public class UpdateStockRequestDto
    {
        public int Stock { get; set; }

        public Guid ProductId { get; set; }
    }
}
