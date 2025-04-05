using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace myListofPeople.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Models.myClassExample> example = new List<Models.myClassExample>();

            example.Add(new Models.myClassExample { StudentNumber = "u12345678", Name = "Name 1", Surname = "Surname 1", Email = "u12345678@tuks.co.za", myLink = "/HTML/People1.html" });
            example.Add(new Models.myClassExample { StudentNumber = "u12345678", Name = "Name 2", Surname = "Surname 2", Email = "u12345678@tuks.co.za" });
            example.Add(new Models.myClassExample { StudentNumber = "u12345678", Name = "Name 3", Surname = "Surname 3", Email = "u12345678@tuks.co.za" });
            example.Add(new Models.myClassExample { StudentNumber = "u12345678", Name = "Name 4", Surname = "Surname 4", Email = "u12345678@tuks.co.za" });
            example.Add(new Models.myClassExample { StudentNumber = "u12345678", Name = "Name 5", Surname = "Surname 5", Email = "u12345678@tuks.co.za" });

            return View(example);
            
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