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
    public class AdminManager : IAdminService
    {
        private readonly IAdminDal _adminDal;
        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public async Task<int?> LoginControl(LoginVM loginVM)
        {
            var control = await _adminDal.GetAsync(p => p.UserName == loginVM.Username && p.Password == loginVM.Password && p.Active == true);
            return control != null ? control.Id : null;
        }  
        public async Task<Admin> GetAdminById(int id)
        {
            return await _adminDal.GetAsync(p => p.Id == id);
        }
        public async Task<bool> UpdateAdmin(Admin admin)
        {
            return await _adminDal.UpdateAsync(admin);
        }
    }
}
