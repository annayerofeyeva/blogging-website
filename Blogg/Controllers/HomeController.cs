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
            posts.Reverse();
            List<Post> lastFourPosts = posts.Take(4).ToList();
            return View(lastFourPosts);
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