using EShop.API.Dto;
using FluentValidation;

namespace EShop.API.Validators.v1;

public class CreateProductRequestDtoValidator : AbstractValidator<CreateProductRequestDto>
{
    public CreateProductRequestDtoValidator()
    {
        RuleFor(re => re.Name).NotEmpty()
            .NotNull()
            .MaximumLength(250)
            .MinimumLength(6)
            .WithMessage("Name is not valid");

        RuleFor(re => re.Stock)
            .GreaterThan(0)
            .NotNull()
            .WithMessage("Stock is not valid");
    }
}
