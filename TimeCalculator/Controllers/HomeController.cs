using Microsoft.AspNetCore.Mvc;
using CalculatorCode.Models;
using System;

namespace CalculatorCode.Controllers
{
    public class HomeController : Controller
    {
        AllCalculators allCalculators = new AllCalculators();
        public IActionResult index()
        {
            // Change to loop with list of calculator links provided AllCalculators class
            return View();
        }

        [HttpPost]
        public IActionResult Index(TimeCalculatorModel model)
        {
            // Only show positive values

            if (model.InputOne > model.InputTwo)
            {
                model.Result = model.CalculateResultReverse();
            }
            else
            {
                model.Result = model.CalculateTimeSpanResult();
            }

            return View(model);
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
