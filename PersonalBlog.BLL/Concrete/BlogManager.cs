using PersonalBlog.BLL.Abstract;
using PersonalBlog.DAL.Abstract;
using PersonalBlog.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.BLL.Concrete
{
    public class BlogManager : IBlogService
    {
        private readonly IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }
        public async Task<List<Blog>> GetBlogs(Expression<Func<Blog,bool>> filter)
        {
            return await _blogDal.GetAllAsync(filter);
        }
        public async Task<List<Blog>> GetBlogs()
        {
            return await _blogDal.GetAllAsync();
        }
        public async Task<bool> CreateBlog(Blog blog)
        {
            return await _blogDal.CreateAsync(blog);
        }
        public async Task<Blog> GetBlogById(int id)
        {
            return await _blogDal.GetAsync(p => p.Id == id);
        }
        public async Task<bool> UpdateBlog(Blog blog)
        {
            return await _blogDal.UpdateAsync(blog);
        }
        public async Task<bool> ChangeBlogStatus(int id)
        {
            var control = await _blogDal.GetAsync(p => p.Id == id);
            control.Active = !control.Active;

            return await _blogDal.UpdateAsync(control);
        }

    }
}
