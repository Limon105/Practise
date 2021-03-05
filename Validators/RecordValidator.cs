using FluentValidation;
using Practise.Models;
using Practise.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practise.ViewModels
{
    public class RecordValidator : AbstractValidator<Record>
    {
        public RecordValidator()
        {
            this.RuleFor(c => c.PhoneNumber)
                .Cascade(CascadeMode.Stop)
                .NotNull().WithMessage("")
                .NotEmpty().WithMessage("")
                .Matches(@"/^\+?([0-9]{3})\)?[-. ]?([0-9]{2})[-. ]?([0-9]{3})[-. ]?([0-9]{4})$/").WithMessage("");

            this.RuleFor(c => c.Status)
                .Cascade(CascadeMode.Stop)
                .NotNull().WithMessage("")
                .NotEmpty().WithMessage("");

            this.RuleFor(c => c.DateAdded)
                .Cascade(CascadeMode.Stop)
                .NotNull().WithMessage("")
                .NotEmpty().WithMessage("")
                .Must(date => date == DateTime.Now).WithMessage("");

            this.RuleFor(c => c.DateOfLastUpdate)
                .Cascade(CascadeMode.Stop)
                .NotNull().WithMessage("")
                .NotEmpty().WithMessage("")
                .GreaterThanOrEqualTo(c => c.DateAdded).WithMessage("");

            this.RuleFor(c => c.Address)
                .Cascade(CascadeMode.Stop)
                .NotNull().WithMessage("")
                .NotEmpty().WithMessage("");

        }
    }
}
