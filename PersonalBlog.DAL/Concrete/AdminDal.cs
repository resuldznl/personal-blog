using PersonalBlog.DAL.Abstract;
using PersonalBlog.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.DAL.Concrete
{
    public class AdminDal : Repository<Admin,PersonalBlogDbContext> , IAdminDal
    {
    }
}
