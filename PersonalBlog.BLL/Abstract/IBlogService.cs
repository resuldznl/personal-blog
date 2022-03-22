using PersonalBlog.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.BLL.Abstract
{
    public interface IBlogService
    {
         Task<List<Blog>> GetBlogs(Expression<Func<Blog, bool>> filter);
         Task<List<Blog>> GetBlogs();
         Task<bool> CreateBlog(Blog blog);
         Task<Blog> GetBlogById(int id);
         Task<bool> UpdateBlog(Blog blog);
         Task<bool> ChangeBlogStatus(int id);
    }
}
