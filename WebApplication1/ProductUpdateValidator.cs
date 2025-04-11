using Core.DTOs;
using FluentValidation;
using FluentValidation.AspNetCore;

namespace WebApplication1
{
    public class ProductUpdateValidator : AbstractValidator<ProductUpdateDTO>
    {
        public ProductUpdateValidator()
        {
            RuleFor(x => x.Name).NotEmpty().MaximumLength(100).WithMessage("Product name is required"); ;
            RuleFor(x => x.Description).NotEmpty();
            RuleFor(x => x.Price).GreaterThan(0);
            RuleFor(x => x.StockQuantity).GreaterThanOrEqualTo(0);
            RuleFor(x => x.Category).NotEmpty().WithMessage("Description Should be related to product and full descriptive and genuine");
        }
    }
}
