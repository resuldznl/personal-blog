using PersonalBlog.BLL.Abstract;
using PersonalBlog.DAL.Abstract;
using PersonalBlog.Entities.ComplexType;
using PersonalBlog.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.BLL.Concrete
{
    public class SkillManager : ISkillService
    {
        private readonly ISkillDal _skillDal;
        public SkillManager(ISkillDal skillDal)
        {
            _skillDal = skillDal;
        }
        public async Task<List<Skill>> GetSkills()
        {
            return await _skillDal.GetAllAsync();
        }
        public async Task<List<Skill>> GetSkills(Expression<Func<Skill,bool>> filter)
        {
            return await _skillDal.GetAllAsync(filter);
        }
        public async Task<bool> CreateSkill(Skill skill)
        {
            return await _skillDal.CreateAsync(skill);
        }
        public async Task<bool> UpdateSkill(Skill updateSkill)
        {
            var skillControl = await _skillDal.GetAsync(p => p.Id == updateSkill.Id);
            skillControl.SkillName = updateSkill.SkillName;
            skillControl.Degree = updateSkill.Degree;

            return await _skillDal.UpdateAsync(skillControl);
        }
        public async Task<Skill> GetSkill(int Id)
        {
            return await _skillDal.GetAsync(p => p.Id == Id);
        }
        public async Task<bool> ChangeStatus(int Id)
        {
            var control = await _skillDal.GetAsync(p => p.Id == Id);
            control.Active = !control.Active;

            return await _skillDal.UpdateAsync(control);
        }
    }
}
