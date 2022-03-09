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
    public class ExperienceManager : IExperienceService
    {
        private readonly IExperienceDal _experienceDal;
        public ExperienceManager(IExperienceDal experienceDal)
        {
            _experienceDal = experienceDal;
        }
        public async Task<List<Experience>> GetExperiences(Expression<Func<Experience,bool>> filter)
        {
            return await _experienceDal.GetAllAsync(filter);
        }
        public async Task<List<Experience>> GetExperiences()
        {
            return await _experienceDal.GetAllAsync();
        }
        public async Task<bool> ChangeStatus(int id)
        {
            var control = await _experienceDal.GetAsync(p => p.Id == id);
            control.Active = !control.Active;

            return await _experienceDal.UpdateAsync(control);
        }
        public async Task<bool> CreateExperience(Experience experience)
        {
            return await _experienceDal.CreateAsync(experience);
        }
        public async Task<Experience> GetExperienceById(int id)
        {
            return await _experienceDal.GetAsync(p => p.Id == id);
        }
        public async Task<bool> UpdateExperience(Experience experience)
        {
            return await _experienceDal.UpdateAsync(experience);
        }
    }
}
