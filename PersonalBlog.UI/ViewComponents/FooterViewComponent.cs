﻿using Microsoft.AspNetCore.Mvc;
using PersonalBlog.BLL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalBlog.UI.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        private readonly IPersonalInformationService _personalInformationService;
        public FooterViewComponent(IPersonalInformationService personalInformationService)
        {
            _personalInformationService = personalInformationService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _personalInformationService.GetPersonalInformation());
        }
    }
}
