using Stockmate.Domain.Entities;
using FluentValidation;

namespace Stockmate.Domain.Validations;

public class ProductValidation : AbstractValidator<Product>
{
    public ProductValidation()
    {
        RuleFor(p => p.ManufacturingDate)
            .NotEmpty().WithMessage("A data de fabricação do produto é obrigatória.")
            .LessThan(p => p.ExpirationDate).WithMessage("A data de fabricação não pode ser maior ou igual à data de validade.");
    }
}
