using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Options;
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
    public class HomeController : Controller
    {
        private readonly IAdminService _adminService;
        private readonly IStringLocalizer<SharedResource> _localizer;
        private readonly IMapper _mapper;
        private readonly IOptions<RequestLocalizationOptions> _options;

        public HomeController(IOptions<RequestLocalizationOptions> options,IMapper mapper,IStringLocalizer<SharedResource> localizer,IAdminService adminService)
        {
            _adminService = adminService;
            _localizer = localizer;
            _mapper = mapper;
            _options = options;
        }

        [Route("/AdminPanel")]
        [AdminAuthFilter]
        public IActionResult AdminPanel()
        {
            return View();
        }
        [Route("/Settings")]
        [AdminAuthFilter]
        public async Task<IActionResult> Settings()
        {
            return View(_mapper.Map<UpdateAdminVM>(await _adminService.GetAdminById((int)HttpContext.Session.GetInt32("adminUserId"))));
        }
        [Route("/Settings")]
        [AdminAuthFilter]
        [HttpPost]
        public async Task<IActionResult> Settings(UpdateAdminVM updateAdminVM)
        {
            if (!ModelState.IsValid)
                return View(updateAdminVM);

            if (await _adminService.UpdateAdmin(_mapper.Map<Admin>(updateAdminVM)))
                TempData["info"] = _localizer["UpateadminInfoSuccess"].ToString();
            else
                TempData["info"] = _localizer["UpateadminInfoFailed"].ToString();

            return RedirectToAction("Settings", "Home", new { Area = "AdminPanel" });

        }
        [Route("/Login")]
        public IActionResult Login()
        {
            if(HttpContext.Session.GetInt32("adminUserId") == null)
                return View();

            return RedirectToAction("AdminPanel", "Home", new { Area = "AdminPanel" });
        }
        [Route("/Login")]
        [HttpPost]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            int? userControl = await _adminService.LoginControl(loginVM);
            if(userControl != null)
            {
                HttpContext.Session.SetInt32("adminUserId", (int)userControl);
                return RedirectToAction("AdminPanel","Home",new { Area = "AdminPanel"});
            }

            TempData["loginInfo"] = _localizer["loginError"].ToString();
            return View();
        }
        [AdminAuthFilter]
        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Home", new { Area = "AdminPanel" });
        }
        public IActionResult CultureManagement(string culture, string returnUrl)
        {
            foreach (var item in _options.Value.SupportedUICultures)
            {
                if (item.Name == culture)
                {
                    Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName, CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)), new CookieOptions { Expires = DateTimeOffset.Now.AddHours(2) });
                }
            }
            return LocalRedirect(returnUrl);
        }
    }
}
