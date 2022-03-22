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
         Task<bool> CreateContact(Contact contact);
         Task<bool> IsThereNewContact();
         Task<List<Contact>> GetAllContacts();
    }
}
