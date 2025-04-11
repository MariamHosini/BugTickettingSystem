using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTickettingSystem.BL
{
    public class FileUploadDTO
    {
        public IFormFile File { get; set; }
    }

}
