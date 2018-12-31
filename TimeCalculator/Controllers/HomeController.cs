using Microsoft.AspNetCore.Mvc;
using CalculatorCode.Models;
using System;

namespace CalculatorCode.Controllers
{
    public class HomeController : Controller
    {
        AllCalculators allCalculators = new AllCalculators();

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
