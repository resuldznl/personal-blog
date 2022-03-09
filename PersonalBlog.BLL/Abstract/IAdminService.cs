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
        public Task<int?> LoginControl(LoginVM loginVM);
        public Task<Admin> GetAdminById(int id);
        public Task<bool> UpdateAdmin(Admin admin);
    }
}
