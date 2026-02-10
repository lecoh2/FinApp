using FinApp.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinApp.Domain.Validators
{
    public class CategoriaValidator : AbstractValidator<Categoria>
    {
        public CategoriaValidator()
        {
            RuleFor(c => c.Nome)
                    .NotEmpty()
                    .WithMessage("O Nome da categoria é obrigatório.")
                    .Length(6, 50)
                    .WithMessage("O Nome da categoria deve conter entre 6 e 50 caracteres.");

        }
    }
}
