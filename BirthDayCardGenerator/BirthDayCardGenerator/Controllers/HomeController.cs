using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BirthDayCardGenerator.Models;
using Microsoft.AspNetCore.Mvc;

namespace BirthDayCardGenerator.Controllers
{
    public class HomeController : Controller
    {

        public HomeController( )
        {
           
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(ResponseForm responseForm )
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