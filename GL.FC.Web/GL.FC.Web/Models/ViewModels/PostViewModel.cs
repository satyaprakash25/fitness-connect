using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace GL.FC.Web
{
    public class PostViewModel
    {
        public string Description { get; set; }

        public int CategoryId { get; set; }

        public IList<IFormFile> Files { get; set; }
    }
}