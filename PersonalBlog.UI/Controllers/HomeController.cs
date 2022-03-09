using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Options;
using MimeKit;
using PersonalBlog.BLL.Abstract;
using PersonalBlog.BLL.Concrete;
using PersonalBlog.Entities.ComplexType;
using PersonalBlog.Entities.Models;
using PersonalBlog.UI.EmailControl;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalBlog.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOptions<RequestLocalizationOptions> _options;
        private readonly IStringLocalizer<SharedResource> _localizer;
        private readonly IMapper _mapper;
        private readonly IContactService _contactService;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public HomeController(IWebHostEnvironment webHostEnvironment,IStringLocalizer<SharedResource> localizer,IContactService contactService,IOptions<RequestLocalizationOptions> options , IMapper mapper)
        {
            _options = options;
            _mapper = mapper;
            _contactService = contactService;
            _localizer = localizer;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(CreateContactVM createContactVM)
        {
            if (!ModelState.IsValid)
                return View();
            if (await _contactService.CreateContact(_mapper.Map<Contact>(createContactVM)))
                TempData["info"] = _localizer["createContactSuccess"].ToString();
            else
                TempData["info"] = _localizer["createContactFail"].ToString();

            return RedirectToAction("Index","Home");
        }
        public IActionResult DownloadCV(string CVPath)
        {
            return PhysicalFile(_webHostEnvironment.WebRootPath + CVPath, MimeTypes.GetMimeType(CVPath), Path.GetFileName(CVPath));
        }
        public IActionResult CultureManagement(string culture,string returnUrl)
        {
            foreach (var item in _options.Value.SupportedUICultures)
            {
                if(item.Name == culture)
                {
                    Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName, CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)), new CookieOptions { Expires = DateTimeOffset.Now.AddHours(2) });
                }
            }
            return LocalRedirect(returnUrl);
        }
       
    }
}
