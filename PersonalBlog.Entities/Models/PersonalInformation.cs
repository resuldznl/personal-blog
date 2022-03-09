using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Entities.Models
{
    public class PersonalInformation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string JobTitleTr { get; set; }
        public string JobTitleEn { get; set; }
        public string DegreeTr { get; set; }
        public string DegreeEn { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime Birthday { get; set; }
        public int Experience { get; set; }
        public string Email { get; set; }
        public bool Freelance { get; set; }
        public string AboutTR { get; set; }
        public string AboutEN { get; set; }
        public string Twitter { get; set; }
        public string Facebook { get; set; }
        public string LinkedIn { get; set; }
        public string Instagram { get; set; }
        public string Photo { get; set; }
        public string CVTr { get; set; }
        public string CVEn { get; set; }
        public bool Active { get; set; }
        public DateTime CreateDate { get; set; }

    }
}
