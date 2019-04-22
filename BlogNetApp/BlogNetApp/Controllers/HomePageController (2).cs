using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BlogNetApp.DAL;
using BlogNetApp.Models;

namespace BlogNetApp.Controllers
{
    public class HomePageController : Controller
    {


        public string Title { get; set; }
        private BlogContext db = new BlogContext();
        public ActionResult Index(BlogNetApp.Models.User usermodel)
        {


                var posts = db.Posts.Include(p => p.Category).Include(p => p.User);
            return View(posts.ToList());
        }
    }
}