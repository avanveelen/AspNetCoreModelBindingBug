using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace ListBindingAspNetCoreBug.Models
{
    public class Content
    {
        public string Name { get; set; }

        public string Value { get; set; }

        public IFormFile File { get; set; }
    }
}