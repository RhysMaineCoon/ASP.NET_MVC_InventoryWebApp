using MVC_InventoryWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_InventoryWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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
            var model = new ContactViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Contact(ContactViewModel model)
        {
            // Send the email here
            return RedirectToAction("Index");
        }

    }
}