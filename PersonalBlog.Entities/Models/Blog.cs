using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Entities.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string TitleTr { get; set; }
        public string TitleEn { get; set; }
        public string DescriptionTR { get; set; }
        public string DescriptionEN { get; set; }
        public bool Active { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
