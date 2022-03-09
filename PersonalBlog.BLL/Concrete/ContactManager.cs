using PersonalBlog.BLL.Abstract;
using PersonalBlog.DAL.Abstract;
using PersonalBlog.Entities.ComplexType;
using PersonalBlog.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.BLL.Concrete
{
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public async Task<bool> CreateContact(Contact contact)
        {

            return await _contactDal.CreateAsync(contact);
        }

        public async Task<bool> IsThereNewContact()
        {
            var allcontact = await _contactDal.GetAllAsync();
            foreach (var item in allcontact)
            {
                TimeSpan timeSpan = DateTime.Now - item.CreateDate;
                if (timeSpan.Minutes <= 5 && timeSpan.Days == 0 && timeSpan.Hours == 0)
                    return true;
            }
            return false;
        }
        public async Task<List<Contact>> GetAllContacts()
        {
            var allContacts = await _contactDal.GetAllAsync();
            return allContacts;
        }
    }
}
