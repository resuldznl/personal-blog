using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Entities.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public string SkillName { get; set; }
        public int Degree { get; set; }
        public bool Active { get; set; }
        public DateTime CreateDate { get; set; }

    }
}
