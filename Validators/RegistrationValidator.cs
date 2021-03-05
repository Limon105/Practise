using FluentValidation;
using Practise.ViewModels;
using System.Linq;

namespace Practise.Validators
{
    public class RegistrationValidator : AbstractValidator<RegisterViewModel>
    {
        public RegistrationValidator()
        {
            this.RuleFor(c => c.Name)
               .Cascade(CascadeMode.Stop)
               .NotEmpty().WithMessage(ErrorMessages.userNameErrorIsEmpty)
               .MinimumLength(2).WithMessage(ErrorMessages.userNameErrorMinimumLength)
               .MaximumLength(20).WithMessage(ErrorMessages.userNameErrorMaximumLenght)
               .Must(this.BeValidName).WithMessage(ErrorMessages.userNameErrorMustBeValidName);

            this.RuleFor(c => c.Password)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage(ErrorMessages.userPasswordErrorEmpty)
                .MinimumLength(8).WithMessage(ErrorMessages.userPasswordErrorMinimumLenght)
                .MaximumLength(16).WithMessage(ErrorMessages.userPasswordErrorMaximumLenght)
                .Matches(@"((?=.*\d)(?=.*[A-Z]).{8,50})").WithMessage(ErrorMessages.userPasswordErrorMatches);

            this.RuleFor(x => x.ConfirmPassword)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage(ErrorMessages.userConfirmPasswordErrorEmpty)
                .MinimumLength(8).WithMessage(ErrorMessages.userConfirmPasswordErrorMinimumLenght)
                .MaximumLength(16).WithMessage(ErrorMessages.userConfirmPasswordErrorMaximumLenght)
                .Matches(@"((?=.*\d)(?=.*[A-Z]).{8,50})").WithMessage(ErrorMessages.userConfirmPasswordErrorMatches)
                .Equal(x => x.Password).WithMessage(ErrorMessages.userConfirmPasswordErrorEqualPasword);
        }

        protected bool BeValidName(string name)
        {
            name = name.Replace(" ", string.Empty);
            return name.All(char.IsLetter);
        }
    }
}
