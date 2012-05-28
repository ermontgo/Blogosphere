using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blogosphere.Models;

namespace Blogosphere.Controllers
{
    public class BlogController : Controller
    {
        private BlogContext ctx = new BlogContext();

        public ActionResult Index()
        {
            return View(ctx.Posts.ToList());
        }

        public ActionResult Item(string id)
        {
            return View(ctx.Posts.Find(id));
        }
    }
}
