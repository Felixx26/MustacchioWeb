﻿using System.Web.Mvc;

namespace MustacchioWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Gallery()
        {
            
            return View();
        }
        public ActionResult GalleryPost(string image)
        {
            ViewBag.Image = image;
            return View();
        }
        public ActionResult Blog()
        {

            return View();
        }
        public ActionResult BlogPost(string image)
        {
            ViewBag.Image = image;
            return View();
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