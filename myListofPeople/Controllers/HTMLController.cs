using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace myListofPeople.Controllers
{
    public class HTMLController : Controller
    {
        // GET: HTML
        public ActionResult Person1()
        {
            return View();
        }

        public ActionResult Person2()
        {
            return View();
        }

        public ActionResult Person3()
        {
            return View();
        }

        public ActionResult Person4()
        {
            return View();
        }

        public ActionResult Person5()
        {
            return View();
        }

        public ActionResult DisplayImage(string imageName)
        {
            string imagePath = Server.MapPath("/Images1/" + imageName);
            return File(imagePath, "image/jpeg"); // Adjust the content type based on the image type
        }
    }
}