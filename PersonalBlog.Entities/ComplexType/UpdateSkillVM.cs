using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Entities.ComplexType
{
    public class UpdateSkillVM
    {
        public int? Id { get; set; }
        public string SkillName { get; set; }
        public int? Degree { get; set; }
    }
}
