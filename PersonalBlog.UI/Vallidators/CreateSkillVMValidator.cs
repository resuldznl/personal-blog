using FluentValidation;
using Microsoft.Extensions.Localization;
using PersonalBlog.Entities.ComplexType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalBlog.UI.Vallidators
{
    public class CreateSkillVMValidator : AbstractValidator<CreateSkillVM>
    {
        public CreateSkillVMValidator(IStringLocalizer<SharedResource> localizer)
        {
            RuleFor(p => p.SkillName).NotNull().WithMessage(localizer["SkillNameRequired"]);
            RuleFor(p => p.Degree).NotNull().WithMessage(localizer["DegreeRequired"]);
        }
    }
}
