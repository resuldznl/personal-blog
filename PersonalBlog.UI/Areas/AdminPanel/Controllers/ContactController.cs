using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PersonalBlog.BLL.Abstract;
using PersonalBlog.Entities.ComplexType;
using PersonalBlog.UI.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalBlog.UI.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    [AdminAuthFilter]
    public class ContactController : Controller
    {

        private readonly IContactService _contactService;
        private readonly IMapper _mapper;
        public ContactController(IMapper mapper,IContactService contactService)
        {
            _contactService = contactService;
            _mapper = mapper;
        }

        [Route("/Contacts")]
        public async Task<IActionResult> Contacts()
        {
            return View(_mapper.Map<List<ContactListVM>>(await _contactService.GetAllContacts()));
        }
    }
}
