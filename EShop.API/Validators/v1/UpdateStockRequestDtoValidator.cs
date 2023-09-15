using EShop.API.Dto;
using FluentValidation;

namespace EShop.API.Validators.v1
{
    public class UpdateStockRequestDtoValidator : AbstractValidator<UpdateStockRequestDto>
    {
        public UpdateStockRequestDtoValidator()
        {
            RuleFor(re => re.Stock)
                .GreaterThan(0)
                .WithMessage("Stock is not null");
        }
    }
}
