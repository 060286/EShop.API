using EShop.API.Dto;
using EShop.API.Services.v1.Interface;

namespace EShop.API.Services.v1;

public class HomePageService : IHomePageService
{
    public GetProductDetailResponseDto GetProductDetail(Guid productId)
    {
        return new GetProductDetailResponseDto
        {
            Id = productId,
            Name = "This is a product's name",
            Stock = 100
        };
    }
}
