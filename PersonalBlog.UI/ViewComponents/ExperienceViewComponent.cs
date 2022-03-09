using Microsoft.AspNetCore.Mvc;
using PersonalBlog.BLL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalBlog.UI.ViewComponents
{
    public class ExperienceViewComponent : ViewComponent
    {

        private readonly IExperienceService _experienceService;
        public ExperienceViewComponent(IExperienceService experienceService)
        {
            _experienceService = experienceService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _experienceService.GetExperiences(p=>p.Active == true));
        }
    }
}
