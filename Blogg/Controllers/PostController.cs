using Blogg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blogg.Controllers
{
    public class PostController : Controller
    {
        public ActionResult Index()
        {
            PostContext postContext = new PostContext();
            List<Post> posts = postContext.Posts.ToList();
            return View(posts);
        }

        public ActionResult Details(int id)
        {
            PostContext postContext = new PostContext();
            Post post = postContext.Posts.Single(pst => pst.postId == id);
            return View(post);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection formCollection)
        {
            Post post = new Post();
            post.postAuthor = "Alexander";
            post.postAddedAt = DateTime.Now;
            post.postContent = formCollection["postContent"];
            post.AddPost(post);
            return RedirectToAction("Index");
        }
    }
}