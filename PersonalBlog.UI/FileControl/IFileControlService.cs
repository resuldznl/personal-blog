using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalBlog.UI.FileControl
{
    public interface IFileControlService
    {
        Task<string> AddFile(IFormFile formFile, string path);
    }
}
