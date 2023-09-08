using EShop.API.Dto;
using EShop.API.Services.v1.Interface;
using FastEndpoints;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;

namespace EShop.API.Endpoints;

public class GetProductDetailEndpoint : Endpoint<GetProductDetailRequestDto,
    Results<Ok<GetProductDetailResponseDto>, NotFound>>
{
    private readonly IHomePageService _homePageService;

    public GetProductDetailEndpoint(IHomePageService homePageService)
    {
        _homePageService = homePageService;
    }

    public override void Configure()
    {
        Post("product-detail");
        AllowAnonymous();

        // Will only allow 10 requests from each unique client within a 60 second window. 
        // Will thrown a status error 409
        Throttle(hitLimit: 10, durationSeconds: 60);
    }

    public override async Task<Results<Ok<GetProductDetailResponseDto>, NotFound>> HandleAsync([Microsoft.AspNetCore.Mvc.FromBody] GetProductDetailRequestDto req, CancellationToken ct)
    {
        await Task.CompletedTask;

        var result = _homePageService.GetProductDetail(productId: req.Id);

        return TypedResults.Ok(result);
    }
}
