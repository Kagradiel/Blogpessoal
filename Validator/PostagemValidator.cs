using blogpessoal.Model;
using FluentValidation;

namespace blogpessoal.Validator
{
    public class PostagemValidator : AbstractValidator<Postagem>
    {
        public PostagemValidator()
        {
            RuleFor(p => p.Titulo)
                .NotEmpty().WithMessage("O titulo não pode estar vazio")
                .MinimumLength(5).WithMessage("O titulo deve ter no minimo 5 caracteres")
                .MaximumLength(100).WithMessage("O titulo deve ter no maximo 10 caracteres");

            RuleFor(p => p.Texto)
                .NotEmpty().WithMessage("O titulo não pode estar vazio")
                .MinimumLength(10).WithMessage("O texto deve ter no minimo 10 caracteres")
                .MaximumLength(1000).WithMessage("O texto deve ter no maximo 1000 caracteres");
        }

    }
}