using EShop.API.Constant;
using EShop.API.Dto;
using FluentValidation;

namespace EShop.API.Validators.v1
{
    public class GetProductDetailRequestDtoValidator : AbstractValidator<GetProductDetailRequestDto>
    {
        public GetProductDetailRequestDtoValidator()
        {
            RuleFor(request => request.Id)
                .NotEmpty()
                .NotNull()
                .WithMessage(MessageConstant.EmptyProductIdMessage)
                .WithErrorCode(CommonConstant.BadRequestStatus);
        }
    }
}
