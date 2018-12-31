using Microsoft.AspNetCore.Mvc;
using System;

namespace CalculatorCode.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View("Index");
        }

        public IActionResult About()
        {

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
    }
}
