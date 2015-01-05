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
            Post post = new Post()
            {
                postId = 1,
                postAuthor = "Alexander Schechter",
                postAddedAt = DateTime.Now,
                postContent = "Welcome to my blogging website!!!"
            };
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