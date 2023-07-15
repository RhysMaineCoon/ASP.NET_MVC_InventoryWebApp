using MailKit.Net.Smtp;
using MimeKit;
using MVC_InventoryWebApp.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
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
            ViewBag.Message = "This is your digital inventory.";

            return View();
        }

        //Contact Page 
        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Us!";
            var model = new ContactViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Contact(ContactViewModel model)
        {
            //Save this for a another time 
            // Send the email here
            /* var emailSettings = Configuration.GetSection("EmailSettings").Get<EmailSettings>();

            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(model.Name, model.Email));
            message.To.Add(new MailboxAddress("Your Name", "your-email@example.com"));
            message.Subject = model.Subject;

            message.Body = new TextPart("plain")
            {
                Text = model.Message
            };

            //var emailSettings = new EmailSettings();
            //Configuration.GetSection("EmailSettings").Bind(emailSettings);

            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, false);
               // client.Authenticate(emailSettings.Email, emailSettings.Password);
                
                client.Send(message);
                client.Disconnect(true);
            }
            */

            return View();
                //RedirectToAction("Success");
        }

        public ActionResult Success()
        {
            return View();
        }

    }
}