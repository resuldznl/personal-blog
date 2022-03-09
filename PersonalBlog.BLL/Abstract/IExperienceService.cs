using PersonalBlog.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.BLL.Abstract
{
    public interface IExperienceService
    {
        public Task<List<Experience>> GetExperiences(Expression<Func<Experience, bool>> filter);
        public Task<List<Experience>> GetExperiences();
        public Task<bool> ChangeStatus(int id);
        public Task<bool> CreateExperience(Experience experience);
        public Task<Experience> GetExperienceById(int id);
        public Task<bool> UpdateExperience(Experience experience);
    }
}
