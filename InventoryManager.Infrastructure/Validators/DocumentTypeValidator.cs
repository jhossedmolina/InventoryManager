using FluentValidation;
using InventoryManager.Core.DTOs;

namespace InventoryManager.Infrastructure.Validators
{
    public class DocumentTypeValidator : AbstractValidator<DocumentTypeDto>
    {
        public DocumentTypeValidator()
        {
            RuleFor(documentType => documentType.Name)
                .NotNull()
                .Length(5, 20);

            RuleFor(documentType => documentType.Code)
                .NotNull()
                .Length(1, 5);
        }
    }
}
