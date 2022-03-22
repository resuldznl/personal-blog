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
         Task<List<Skill>> GetSkills();
         Task<List<Skill>> GetSkills(Expression<Func<Skill, bool>> filter);
         Task<bool> CreateSkill(Skill skill);
         Task<bool> UpdateSkill(Skill updateSkill);
         Task<Skill> GetSkill(int Id);
         Task<bool> ChangeStatus(int Id);
    }
}
