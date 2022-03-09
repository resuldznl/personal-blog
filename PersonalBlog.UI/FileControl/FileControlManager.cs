using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalBlog.UI.FileControl
{
    public class FileControlManager : IFileControlService
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        public FileControlManager(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<string> AddFile(IFormFile formFile , string path)
        {
            string location = Path.Combine(_webHostEnvironment.WebRootPath + path + formFile.FileName);
            using(var stream = new FileStream(location, FileMode.Create))
            {
                await formFile.CopyToAsync(stream);
            }
            return path + formFile.FileName;
        }
    }
}
