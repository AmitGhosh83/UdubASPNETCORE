using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BirthDayCardGenerator1.Models;
using Microsoft.AspNetCore.Mvc;

namespace BirthDayCardGenerator1.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(ResponseForm responseForm)
        {
            if (ModelState.IsValid)
            {
                return View("Details", responseForm);
            }
            else
                return View();
        }
    }
}