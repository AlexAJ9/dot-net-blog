using BlogNetApp.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogNetApp.Models;

namespace BlogNetApp.Controllers
{
    
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(BlogNetApp.Models.User usermodel)
        {

            BlogContext db = new BlogContext();
            
          

            var userDetails = db.Users.Where(x => x.Username== usermodel.Username && x.Password ==usermodel.Password).FirstOrDefault();

                if (userDetails == null)
                {
                    //userModel.LoginErrorMessage= "Wrong Username or Password!";
                    return View("Index", usermodel);
                }
                else
                {
                    
                    Session["UserId"] = userDetails.ID;
                    return RedirectToAction("Index", "Post");
                }
            
            return View();
        }

    }
}
