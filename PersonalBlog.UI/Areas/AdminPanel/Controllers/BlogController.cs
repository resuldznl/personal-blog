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
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<SharedResource> _localizer;
        public BlogController(IStringLocalizer<SharedResource> localizer,IMapper mapper,IBlogService blogService)
        {
            _blogService = blogService;
            _mapper = mapper;
            _localizer = localizer;
        }

        [Route("/Blogs")]
        public async Task<IActionResult> Blogs()
        {
            return View(await _blogService.GetBlogs());
        }
        [Route("/CreateBlog")]
        public IActionResult CreateBlog()
        {
            return View();
        }
        [Route("/CreateBlog")]
        [HttpPost]
        public async Task<IActionResult> CreateBlog(CreateBlogVM createBlogVM)
        {
            if (await _blogService.CreateBlog(_mapper.Map<Blog>(createBlogVM)))
                TempData["info"] = _localizer["createBlogSuccess"].ToString();
            else
                TempData["info"] = _localizer["createBlogFailed"].ToString();

            return RedirectToAction("Blogs", "Blog", new { Area = "AdminPanel" });
        }
        [Route("/UpdateBlog")]
        public async Task<IActionResult> UpdateBlog(int blog)
        {
            return View(_mapper.Map<UpdateBlogVM>(await _blogService.GetBlogById(blog)));
        }
        [Route("/UpdateBlog")]
        [HttpPost]
        public async Task<IActionResult> UpdateBlog(UpdateBlogVM updateBlogVM)
        {
            if (await _blogService.UpdateBlog(_mapper.Map<Blog>(updateBlogVM)))
                TempData["info"] = _localizer["updateBlogSuccess"].ToString();
            else
                TempData["info"] = _localizer["updateBlogFailed"].ToString();

            return RedirectToAction("Blogs", "Blog", new { Area = "AdminPanel" });
        }
        public async Task<IActionResult> ChangeBlogStatus(int id)
        {
            return Json(await _blogService.ChangeBlogStatus(id));
        }
    }
}
