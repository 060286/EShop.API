using EShop.API.Dto;
using EShop.API.Entities;
using EShop.API.Exceptions;
using EShop.API.GenericRepository.Interface;
using EShop.API.Services.v1.Interface;
using EShop.API.Uow;

namespace EShop.API.Services.v1;

public class HomePageService : IHomePageService
{
    private readonly IUnitOfWork _uow;
    private readonly IRepository<Product> _productRepository;
    private readonly IRepository<ProductCategory> _productCategoryRepository;

    public HomePageService(IUnitOfWork uow,
        IRepository<Product> productRepository,
        IRepository<ProductCategory> productCategoryRepository)
    {
        _uow = uow;
        _productRepository = productRepository;
        _productCategoryRepository = productCategoryRepository;
    }

    public GetProductDetailResponseDto GetProductDetail(Guid productId)
    {
        var temp = _productRepository.GetAll()
            .Where(x => x.Name.Equals("Atlas: The Story of Pa Salt"));

        return new GetProductDetailResponseDto
        {
            Id = productId,
            Name = "This is a product's name",
            Stock = 100
        };
    }

    public async Task CreateProduct(CreateProductRequestDto requestDto)
    {
        var productCategory = _productCategoryRepository.Get(requestDto.CategoryId);

        if (productCategory == null)
        {
            throw new NotFoundException("Product category is no allow null");
        }

        await _productRepository.CreateAsync(new Product
        {
            Name = requestDto.Name,
            CategoryId = requestDto.CategoryId,
            Stock = requestDto.Stock
        });

        _uow.Completed();
    }
}
