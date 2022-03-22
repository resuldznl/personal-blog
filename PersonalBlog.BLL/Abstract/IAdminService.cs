using PersonalBlog.Entities.ComplexType;
using PersonalBlog.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.BLL.Abstract
{
    public interface IAdminService
    {
         Task<int?> LoginControl(LoginVM loginVM);
         Task<Admin> GetAdminById(int id);
         Task<bool> UpdateAdmin(Admin admin);
    }
}
