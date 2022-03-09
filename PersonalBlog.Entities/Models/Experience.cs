using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Entities.Models
{
    public class Experience
    {
        public int Id { get; set; }
        public string JobTitleTr { get; set; }
        public string JobTitleEn { get; set; }
        public string Company { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string DescriptionTR { get; set; }
        public string DescriptionEN { get; set; }
        public bool Active { get; set; }
        public DateTime CreateDate { get; set; }

    }
}
