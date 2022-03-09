using PersonalBlog.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.BLL.Abstract
{
    public interface IContactService
    {
        public Task<bool> CreateContact(Contact contact);
        public Task<bool> IsThereNewContact();
        public Task<List<Contact>> GetAllContacts();
    }
}
