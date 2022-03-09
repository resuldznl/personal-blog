using FluentValidation;
using Microsoft.Extensions.Localization;
using PersonalBlog.Entities.ComplexType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalBlog.UI.Vallidators
{
    public class UpdateAdminVMValidator : AbstractValidator<UpdateAdminVM>
    {
        public UpdateAdminVMValidator(IStringLocalizer<SharedResource> localizer)
        {
            RuleFor(p => p.UserName).NotNull().WithMessage(localizer["UserNameRequired"]);
            RuleFor(p => p.UserName).MaximumLength(15).WithMessage(localizer["UserNameMaxLength"]);
            RuleFor(p => p.Password).MinimumLength(8).WithMessage(localizer["UserNameMinLength"]);

            RuleFor(p => p.Password).NotNull().WithMessage(localizer["PasswordRequired"]);
            RuleFor(p => p.Password).MaximumLength(15).WithMessage(localizer["PasswordMaxLength"]);
            RuleFor(p => p.Password).MinimumLength(8).WithMessage(localizer["PasswordMinLength"]);

        }
    }
}
