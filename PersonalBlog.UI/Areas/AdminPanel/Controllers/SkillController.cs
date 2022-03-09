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
    public class SkillController : Controller
    {
        private readonly ISkillService _skillService;
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<SharedResource> _localizer;
        public SkillController(IStringLocalizer<SharedResource> localizer, IMapper mapper,ISkillService skillService)
        {
            _skillService = skillService;
            _mapper = mapper;
            _localizer = localizer;
        }

        [Route("/Skills")]
        public async Task<IActionResult> Skills()
        {
            return View(_mapper.Map<List<GetSkillVM>>(await _skillService.GetSkills()));
        }
        [Route("/CreateSkill")]
        public IActionResult CreateSkill()
        {
            return View();
        }
        [Route("/CreateSkill")]
        [HttpPost]
        public async Task<IActionResult> CreateSkill(CreateSkillVM createSkillVM)
        {
            if (!ModelState.IsValid)
                return View();

            TempData["info"] = await _skillService.CreateSkill(_mapper.Map<Skill>(createSkillVM)) == true ? _localizer["SkillCreateSuccessful"].ToString() : _localizer["SkillCreateFailed"].ToString();

            return RedirectToAction("Skills", "Skill", new { Area = "AdminPanel" });
        }
        [Route("/SkillDetail")]
        public async Task<IActionResult> SkillDetail(int skill)
        {
            return View(_mapper.Map<UpdateSkillVM>(await _skillService.GetSkill(skill)));
        }
        [Route("/SkillDetail")]
        [HttpPost]
        public async Task<IActionResult> SkillDetail(UpdateSkillVM updateSkillVM)
        {
            if (!ModelState.IsValid)
                return View(updateSkillVM);

            TempData["info"] = await _skillService.UpdateSkill(_mapper.Map<Skill>(updateSkillVM)) == true ? _localizer["SkillUpdateSuccessful"].ToString() : _localizer["SkillUpdateFailed"].ToString();
            return RedirectToAction("Skills", "Skill", new { Area = "AdminPanel" });

        }
        public async Task<IActionResult> ChangeSkillStatus(int id)
        {
            return Json(await _skillService.ChangeStatus(id));
        }
    }
}
