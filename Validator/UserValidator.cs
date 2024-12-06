using blogpessoal.Model;
using FluentValidation;

namespace blogpessoal.Validator
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.Nome)
                .NotEmpty().WithMessage("Usuario deve ter um nome")
                .MaximumLength(255).WithMessage("Maximo 255 caracteres");

            RuleFor(u => u.Usuario)
                .NotEmpty().WithMessage("Usuario deve ter um nome de usuario")
                .EmailAddress();

            RuleFor(u => u.Senha)
                .NotEmpty().WithMessage("Usuario deve ter uma Senha")
                .MinimumLength(8).WithMessage("Minimo 8 caracteres");

            RuleFor(u => u.Foto)
                .MaximumLength(5000).WithMessage("Maximo 5000 caracteres");

        }
    }
}