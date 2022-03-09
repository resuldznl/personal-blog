using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using PersonalBlog.BLL.Abstract;
using PersonalBlog.Entities.ComplexType;
using PersonalBlog.Entities.Models;
using PersonalBlog.UI.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalBlog.UI.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    [AdminAuthFilter]
    public class ExperinceController : Controller
    {
        private readonly IExperienceService _experienceService;
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<SharedResource> _localizer;
        public ExperinceController(IStringLocalizer<SharedResource> localizer,IMapper mapper,IExperienceService experienceService)
        {
            _experienceService = experienceService;
            _mapper = mapper;
            _localizer = localizer;
        }
        [Route("/Experiences")]
        public async Task<IActionResult> Experiences()
        {
            return View(await _experienceService.GetExperiences());
        }
        [Route("/CreateExperience")]
        public IActionResult CreateExperience()
        {
            return View();
        }
        [Route("/CreateExperience")]
        [HttpPost]
        public async Task<IActionResult> CreateExperience(CreateExperienceVM createExperienceVM)
        {
            if (await _experienceService.CreateExperience(_mapper.Map<Experience>(createExperienceVM)))
                TempData["info"] = _localizer["createExperienceSuccess"].ToString();
            else
                TempData["info"] = _localizer["createExperienceFail"].ToString();

            return RedirectToAction("Experiences", "Experince", new { Area = "AdminPanel" });
        }
        [Route("/UpdateExperience")]
        public async Task<IActionResult> UpdateExperience(int experience)
        {
            return View(_mapper.Map<UpdateExperienceVM>(await _experienceService.GetExperienceById(experience)));
        }
        [Route("/UpdateExperience")]
        [HttpPost]
        public async Task<IActionResult> UpdateExperience(UpdateExperienceVM updateExperienceVM)
        {
            if(await _experienceService.UpdateExperience(_mapper.Map<Experience>(updateExperienceVM)))
                TempData["info"] = _localizer["updateExperienceSuccess"].ToString();
            else
                TempData["info"] = _localizer["updateExperienceFail"].ToString();

            return RedirectToAction("Experiences", "Experince", new { Area = "AdminPanel" });
        }
        public async Task<IActionResult> ChangeExperienceStatus(int id)
        {
            return Json(await _experienceService.ChangeStatus(id));
        }
    }
}
