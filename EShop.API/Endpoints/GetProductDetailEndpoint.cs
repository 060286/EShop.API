using EShop.API.Dto;
using EShop.API.Services.v1.Interface;
using FastEndpoints;

namespace EShop.API.Endpoints;

public class GetProductDetailEndpoint : Endpoint<GetProductDetailRequestDto>
{
    private readonly IHomePageService _homePageService;

    public GetProductDetailEndpoint(IHomePageService homePageService)
    {
        _homePageService = homePageService;
    }

    public override void Configure()
    {
        // Named endpoint 
        Post("product-detail");

        AllowAnonymous();

        // Will only allow 10 requests from each unique client within a 60 second window. 
        // Will thrown a status error 409
        Throttle(hitLimit: 10, durationSeconds: 60);
    }

    public async override Task HandleAsync(GetProductDetailRequestDto req, CancellationToken ct)
    {
        await Task.CompletedTask;

        var result = _homePageService.GetProductDetail(productId: req.Id);


        await SendAsync(result);
    }
}
