using FluentValidation;
using InventoryManager.Core.DTOs;

namespace InventoryManager.Infrastructure.Validators
{
    public class BrandProductValidator : AbstractValidator<BrandProductDto>
    {
        public BrandProductValidator()
        {
            RuleFor(brandProduct => brandProduct.Name)
                .NotEmpty()
                .NotNull()
                .Length(5, 50);
        }
    }
}
