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
         Task<List<Experience>> GetExperiences(Expression<Func<Experience, bool>> filter);
         Task<List<Experience>> GetExperiences();
         Task<bool> ChangeStatus(int id);
         Task<bool> CreateExperience(Experience experience);
         Task<Experience> GetExperienceById(int id);
         Task<bool> UpdateExperience(Experience experience);
    }
}
