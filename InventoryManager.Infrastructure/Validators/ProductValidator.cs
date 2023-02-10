using FluentValidation;
using InventoryManager.Core.DTOs;

namespace InventoryManager.Infrastructure.Validators
{
    public class ProductValidator : AbstractValidator<ProductDto>
    {
        public ProductValidator()
        {
            RuleFor(product => product.Name)
                .NotNull()
                .Length(10, 50);

            RuleFor(product => product.Description)
                .NotNull()
                .Length(10, 100);

            RuleFor(product => product.IdProductCategory)
                .NotNull();
        }
    }
}
