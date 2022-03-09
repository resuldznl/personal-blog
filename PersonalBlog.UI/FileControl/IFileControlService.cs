using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalBlog.UI.FileControl
{
    public interface IFileControlService
    {
        public Task<string> AddFile(IFormFile formFile, string path);
    }
}
