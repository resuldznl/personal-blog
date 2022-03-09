using Microsoft.AspNetCore.Mvc;
using PersonalBlog.BLL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalBlog.UI.ViewComponents
{
    public class SkillViewComponent : ViewComponent
    {
        private readonly ISkillService _skillService;

        public SkillViewComponent(ISkillService skillService)
        {
            _skillService = skillService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _skillService.GetSkills(p=>p.Active == true));
        }
    }
}
