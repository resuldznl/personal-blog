using FluentValidation;
using Microsoft.Extensions.Localization;
using PersonalBlog.Entities.ComplexType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalBlog.UI.Vallidators
{
    public class CreateContactVMValidator : AbstractValidator<CreateContactVM>
    {
        public CreateContactVMValidator(IStringLocalizer<SharedResource> localizer)
        {
            RuleFor(p => p.Email).NotNull().WithMessage(localizer["EmailRequired"]);
            RuleFor(p => p.Email).EmailAddress().WithMessage(localizer["email_EmailAddress"]);
            RuleFor(p => p.Email).MaximumLength(50).WithMessage(localizer["EmailMaxLength"]);

            RuleFor(p => p.Subject).NotNull().WithMessage(localizer["SubjectRequired"]);
            RuleFor(p => p.Subject).MaximumLength(200).WithMessage(localizer["SubjectMaxLength"]);

            RuleFor(p => p.Message).NotNull().WithMessage(localizer["MessageRequired"]);

            RuleFor(p => p.Name).NotNull().WithMessage(localizer["NameSurnameRequired"]);
            RuleFor(p => p.Name).MaximumLength(100).WithMessage(localizer["NameSurnameMaxLength"]);
        }
    }
}
