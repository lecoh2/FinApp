using FinApp.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinApp.Domain.Validators
{
    public class MovimentacaoValidator : AbstractValidator<Movimentacao>
    {
        public MovimentacaoValidator()
        {
            RuleFor(c => c.Nome)
                    .NotEmpty()
                    .WithMessage("O Nome da movimentação é obrigatório.")
                    .Length(6, 50)
                    .WithMessage("O Nome da movimentação deve conter entre 6 e 50 caracteres.");

            RuleFor(c => c.Data)
                    .NotEmpty()
                    .WithMessage("A data da movimentação é obrigatório.")
                    .LessThanOrEqualTo(_ => DateOnly.FromDateTime(DateTime.Now))
                    .WithMessage("A data de movimentação deve ser meno ou igual a data atual.");

            RuleFor(c => c.Valor)
                    .NotEmpty()
                    .WithMessage("O Nome da movimentação é obrigatório.")
                    .GreaterThan(0)
                    .WithMessage("O valor da movimentação deve ser maior que 0.");

            RuleFor(c => c.CategoriaId)
                    .NotEmpty()
                    .WithMessage("O Id da categoria é obrigatório.");

            RuleFor(c => c.Tipo)
                    .NotEmpty()
                    .WithMessage("O tipo movimentação é obrigatório.");
        }
    }
}
