﻿using System.Diagnostics;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.Controllers
{
    public class HomeController : Controller
    {
       

        public HomeController()
        {
            
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Contact()
        {
            var contactmodel = new ContactForm();
            return View(contactmodel);
        }
        //[HttpPost]
        //public JsonResult Contact(IFormCollection form)
        //{
        //   var name = form["name"];
        //    return Json(Ok());
        //}


        [HttpPost]
        public IActionResult Contact(ContactForm form)
        {
            Console.WriteLine(form.ToString());
            return Json(Ok());
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}