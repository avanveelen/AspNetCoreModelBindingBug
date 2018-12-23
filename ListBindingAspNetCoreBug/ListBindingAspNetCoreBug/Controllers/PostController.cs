using System.Collections.Generic;
using ListBindingAspNetCoreBug.Models;
using Microsoft.AspNetCore.Mvc;

namespace ListBindingAspNetCoreBug.Controllers
{
    public class PostController : Controller
    {
        [HttpPost("post")]
        public IActionResult Index(List<Content> content)
        {

            return Content("Reached Action");
        }

        [HttpPost("post2")]
        public IActionResult Index2(Content content)
        {

            return Content("Reached Action 2");
        }
    }
}