using FluentValidation;
using FluentValidation.AspNetCore;
using Core.DTOs;
namespace WebApplication1
{
    public class ProductValidator : AbstractValidator<ProductCreateDTO>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Name).NotEmpty().MaximumLength(100);
            RuleFor(x => x.Description).NotEmpty();
            RuleFor(x => x.Price).GreaterThan(0);
            RuleFor(x => x.StockQuantity).GreaterThanOrEqualTo(0);
            RuleFor(x => x.Category).NotEmpty();
        }
    }
}
