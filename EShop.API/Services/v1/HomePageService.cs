using EShop.API.Constant;
using EShop.API.Dto;
using EShop.API.Entities;
using EShop.API.Exceptions;
using EShop.API.GenericRepository.Interface;
using EShop.API.Guard;
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
        var product = _productRepository.Get(productId);

        return new GetProductDetailResponseDto
        {
            Id = product.Id,
            Name = product.Name,
            Stock = product.Stock
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


    /// <summary>
    /// This function use for update stock.
    /// </summary>
    /// <param name="requestDto"></param>
    /// <returns></returns>
    /// <exception cref="NotFoundException"></exception>
    public async Task UpdateStock(UpdateStockRequestDto requestDto)
    {
        var product = _productRepository.Get(requestDto.ProductId);

        MyGuard.ThrowIfNull<NotFoundException>(product, string.Format(ExceptionsConstant.NotFoundException, typeof(Product)));

        product.Stock = requestDto.Stock;

        await _productRepository.UpdateAsync(product);

        _uow.Completed();
    }
}
