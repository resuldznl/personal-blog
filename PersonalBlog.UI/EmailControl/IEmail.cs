using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalBlog.UI.EmailControl
{
    public interface IEmail 
    {
        Task SendMail();
    }
}
