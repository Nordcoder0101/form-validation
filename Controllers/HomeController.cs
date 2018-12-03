using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FormValidation.Models;

namespace FormValidation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("show/user")]
        public IActionResult About(User user)
        {
           
            return View(user);
            
        }

       [HttpPost("user/create")]
       public IActionResult Create(User user)
       {
           if(ModelState.IsValid)
           {
               return RedirectToAction("About", user);
           }
           else 
           {
               return View("Index");
           }
       }
    }
}
