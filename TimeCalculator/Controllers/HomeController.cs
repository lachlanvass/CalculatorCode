using Microsoft.AspNetCore.Mvc;
using System;

namespace CalculatorCode.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
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
