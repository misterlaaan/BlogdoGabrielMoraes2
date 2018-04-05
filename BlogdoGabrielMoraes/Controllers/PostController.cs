using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogdoGabrielMoraes.Models;

namespace BlogdoGabrielMoraes.Controllers
{
    public class PostsController : Controller
    {
        private ApplicationDbContext _context = new ApplicationDbContext();
        // GET: Posts
        public ActionResult Index()
        {
            var posts = _context.Posts.ToList();

            return View(posts);
        }       
        public ActionResult Edit(int id)
        {
            var postInDb = _context.Posts.SingleOrDefault(p => p.Id == id);
            return View(postInDb);
        }
        public ActionResult New()
        {
            return View();
        }
        public ActionResult Delete(int id)
        {
            var postInDb = _context.Posts.Single(p => p.Id == id);

            if(postInDb == null)
            {
                return HttpNotFound();
            }

            return View(postInDb);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteComplete(int id)
        {
            var postInDb = _context.Posts.Single(p => p.Id == id);
            if (postInDb == null)
                return HttpNotFound();

            _context.Posts.Remove(postInDb);
            _context.SaveChanges();

            return RedirectToAction("Index", "Posts");
        }
        [HttpPost]
        public ActionResult Save(Post post)
        {
            if (post.Id == 0)
            {
                post.DateAdded = DateTime.Now;
                _context.Posts.Add(post);
            }
            else
            {
                var postInDb = _context.Posts.Single(p => p.Id == post.Id);
                postInDb.title = post.title;
                postInDb.DateUpdated = DateTime.Now;
                postInDb.PostingBody = post.PostingBody;

            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Posts");
        }

        public ActionResult Dt(int id)
        {
            var post = _context.Posts.SingleOrDefault(p => p.Id == id);

            if (post == null)
            {
                return HttpNotFound();
            }

            return View(post);
        }

    }
}