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
        public Task<List<Blog>> GetBlogs(Expression<Func<Blog, bool>> filter);
        public Task<List<Blog>> GetBlogs();
        public Task<bool> CreateBlog(Blog blog);
        public Task<Blog> GetBlogById(int id);
        public Task<bool> UpdateBlog(Blog blog);
        public Task<bool> ChangeBlogStatus(int id);
    }
}
