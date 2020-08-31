using Maquina.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Maquina.Controllers
{
    public class HomeController : Controller
    {
        private MaquinaContext db = new MaquinaContext();

        public ActionResult Index(int? id)
        {
            if (id > 0)
            {
                var user = db.Users.Find(id);
                if (user != null)
                {
                    ViewBag.User1 = user.user1;
                    ViewBag.Id = user.Id;
                    if (user.Files.Count > 0) ViewBag.FileId = user.Files.First().Id;
                    ViewBag.Href = "Edit";
                }
            }
            else
            {
                ViewBag.Href = "Login";
                ViewBag.User1 = "Login";
            }
            return View();
        }



        public ActionResult About(int? id)
        {
            var user = db.Users.Find(id);
            if (user != null)
            {
                ViewBag.User1 = user.user1;
                ViewBag.Id = user.Id;
                if (user.Files.Count > 0) ViewBag.FileId = user.Files.First().Id;
                ViewBag.Href = "Edit";
            }
            else
            {
                ViewBag.Href = "Login";
                ViewBag.User1 = "Login";
            }
            return View();
        }

        public ActionResult Contact(int? id)
        {
            var user = db.Users.Find(id);
            if (user != null)
            {
                ViewBag.User1 = user.user1;
                ViewBag.Id = user.Id;
                if (user.Files.Count > 0) ViewBag.FileId = user.Files.First().Id;
                ViewBag.Href = "Edit";
            }
            else
            {
                ViewBag.Href = "Login";
                ViewBag.User1 = "Login";
            }
            return View();
        }
    }
}