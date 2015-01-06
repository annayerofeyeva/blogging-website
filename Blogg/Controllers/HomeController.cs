using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blogg.Models;

namespace Blogg.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            PostContext postContext = new PostContext();
            List<Post> posts = postContext.Posts.ToList();
            return View(posts);
        }

        public ActionResult Post(int id)
        {
            PostContext postContext = new PostContext();
            Post post = postContext.Posts.Single(pst => pst.postId == id);
            return View(post);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}