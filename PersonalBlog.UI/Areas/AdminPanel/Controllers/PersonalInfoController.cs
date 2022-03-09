using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using PersonalBlog.BLL.Abstract;
using PersonalBlog.Entities.ComplexType;
using PersonalBlog.Entities.Models;
using PersonalBlog.UI.Attributes;
using PersonalBlog.UI.FileControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalBlog.UI.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    [AdminAuthFilter]
    public class PersonalInfoController : Controller
    {
        private readonly IFileControlService _fileControl;
        private readonly IPersonalInformationService _personalInformationService;
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<SharedResource> _localizer;
        public PersonalInfoController(IStringLocalizer<SharedResource> localizer,IMapper mapper,IFileControlService fileControl , IPersonalInformationService personalInformationService)
        {
            _fileControl = fileControl;
            _personalInformationService = personalInformationService;
            _mapper = mapper;
            _localizer = localizer;
        }

        [Route("/PersonalInformation")]
        public async Task<IActionResult> Index()
        {
            return View(_mapper.Map<UpdatePersonelInformationVM>(await _personalInformationService.GetPersonalInformation()));
        }
        [Route("/PersonalInformation")]
        [HttpPost]
        public async Task<IActionResult> Index(UpdatePersonelInformationVM updatePersonelInformation)
        {
            if (!ModelState.IsValid)
                return View(updatePersonelInformation);

            updatePersonelInformation.CVTr = updatePersonelInformation.CvTRFile != null ? await _fileControl.AddFile(updatePersonelInformation.CvTRFile, "/CV/") : updatePersonelInformation.CVTr;
            updatePersonelInformation.CVEn = updatePersonelInformation.CvENFile != null ?  await _fileControl.AddFile(updatePersonelInformation.CvENFile, "/CV/") : updatePersonelInformation.CVEn;
            updatePersonelInformation.Photo = updatePersonelInformation.PhotoFile != null ?  await _fileControl.AddFile(updatePersonelInformation.PhotoFile, "/img/") : updatePersonelInformation.Photo;

            TempData["personalUpdateInfo"] = await _personalInformationService.UpdatePersonalInformation(_mapper.Map<PersonalInformation>(updatePersonelInformation)) == true ? _localizer["updatepersonalinfosuccess"].ToString() : _localizer["updatepersonalinfofail"];

            return RedirectToAction("Index", "PersonalInfo", new { Area = "AdminPanel" });
        }
    }
}
