using EShop.API.Dto;
using EShop.API.Services.v1.Interface;
using FastEndpoints;

namespace EShop.API.Endpoints
{
    public class CreateProductEnpoint : Endpoint<CreateProductRequestDto>
    {
        private readonly IHomePageService _homePageService;

        public CreateProductEnpoint(IHomePageService homePageService)
        {
            _homePageService = homePageService;
        }

        public override void Configure()
        {
            Post("/api/create-product");
            AllowAnonymous();
        }

        public override async Task HandleAsync(CreateProductRequestDto req, CancellationToken ct)
        {
            await Task.CompletedTask;

            await _homePageService.CreateProduct(req);
        }
    }
}
