using FluentValidation;
using InventoryManager.Core.DTOs;
using System.Net;

namespace InventoryManager.Infrastructure.Validators
{
    public class ClientValidator : AbstractValidator<ClientDto>
    {
        public ClientValidator()
        {
            RuleFor(client => client.DocNumber)
                .NotNull();

            RuleFor(client => client.IdDocumentType)
                .NotNull();

            RuleFor(client => client.FirstName)
                .NotNull()
                .Length(2, 50);

            RuleFor(client => client.LastName)
                .NotNull()
                .Length(2, 50);

            RuleFor(client => client.ContactNumber)
                .NotNull()
            .Length(5, 20);

            RuleFor(client => client.Address)
                .NotNull()
                .Length(8, 50);

            RuleFor(client => client.IdMunicipalityCountry)
                .NotNull();
        }
    }
}
