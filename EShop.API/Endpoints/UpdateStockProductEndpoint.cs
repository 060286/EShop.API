using EShop.API.Dto;
using EShop.API.Services.v1.Interface;
using FastEndpoints;

namespace EShop.API.Endpoints
{
    public class UpdateStockProductEndpoint : Endpoint<UpdateStockRequestDto>
    {
        private readonly IHomePageService _homePageService;

        public UpdateStockProductEndpoint(IHomePageService homePageService)
        {
            _homePageService = homePageService;
        }

        public override void Configure()
        {
            Post("api/update-stock");

            AllowAnonymous();
        }

        public async override Task HandleAsync(UpdateStockRequestDto req, CancellationToken ct)
        {
            await Task.CompletedTask;

            await _homePageService.UpdateStock(req);
        }
    }
}
