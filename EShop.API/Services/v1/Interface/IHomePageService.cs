﻿using EShop.API.Dto;

namespace EShop.API.Services.v1.Interface;

public interface IHomePageService
{
    GetProductDetailResponseDto GetProductDetail(Guid productId);

    Task CreateProduct(CreateProductRequestDto requestDto);

    Task UpdateStock(UpdateStockRequestDto requestDto);
}
