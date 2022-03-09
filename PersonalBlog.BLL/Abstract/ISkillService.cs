using PersonalBlog.Entities.ComplexType;
using PersonalBlog.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.BLL.Abstract
{
    public interface ISkillService
    {
        public Task<List<Skill>> GetSkills();
        public Task<List<Skill>> GetSkills(Expression<Func<Skill, bool>> filter);
        public Task<bool> CreateSkill(Skill skill);
        public Task<bool> UpdateSkill(Skill updateSkill);
        public Task<Skill> GetSkill(int Id);
        public Task<bool> ChangeStatus(int Id);


    }
}
