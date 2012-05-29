using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blogosphere.Models;

namespace Blogosphere.Controllers
{
    public class AdminController : Controller
    {
        private BlogContext ctx = new BlogContext();

        public ActionResult Index()
        {
            return View(ctx.Posts.ToList());
        }

        public ActionResult Edit(string id = null)
        {
            var blog = ctx.Posts.Find(id);
            if (blog == null)
                return HttpNotFound();
            else
                return View(blog);
        }

        [HttpPost]
        public ActionResult Edit(Blog blog)
        {
            if (ModelState.IsValid)
            {
                ctx.Entry(blog).State = EntityState.Modified;
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(blog);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Blog blog)
        {
            if (ModelState.IsValid)
            {
                ctx.Posts.Add(blog);
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(blog);
        }

        public ActionResult Delete(string id)
        {
            var blog = ctx.Posts.Find(id);
            if (blog == null)
                return HttpNotFound();
            else
                return View(blog);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(string id)
        {
            var blog = ctx.Posts.Find(id);
            ctx.Posts.Remove(blog);
            ctx.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
