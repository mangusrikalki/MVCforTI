using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCforTI.Controllers
{
    public class HomeController : Controller
    {
        Models.mvcdbEntity db = new Models.mvcdbEntity();
        // GET: Home
        public ActionResult Index(Models.student s)
        {
            if (s == null)
                return View();
            else
                return View(s);
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Models.student s)
        {
            Models.student x = (from c in db.students
                                where c.userId == s.userId && c.pswd == s.pswd
                                select c).FirstOrDefault();
            if (x != null)
            {
                return View("Index", x);
            }
            else
            {
                return View("Login");
            }

        }
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Models.student s)
        {
            if (ModelState.IsValid)
            {
                var x = db.students.Where(m => m.userId == s.userId).FirstOrDefault();
                s.firstLogin = DateTime.Now;
                db.students.Add(s);
                db.SaveChanges();
            }
            return View();
        }
        public ActionResult Profile()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult ContactUs()
        {
            return View();
        }
    }
}