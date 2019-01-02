using System;
using Microsoft.AspNetCore.Mvc;
using CalculatorCode.Models;

namespace CalculatorCode.Controllers
{
    public class DogYearsCalculatorController : Controller
    {

        public IActionResult Index()
        {
            SetViewBagValues();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(DogYearsCalculator model)
        {
            SetViewBagValues();
            if (!ModelState.IsValid)
            {
                return View();
            }


            return View(model);
        }

        public void SetViewBagValues()
        {
            ViewBag.Code = AlgorithmCode;
            ViewBag.Instructions = "Calculate Dog Years";
        }

        public const String AlgorithmCode =
@"public int CalculateResut ()
    {
        return InputOne * 7;
    }";
    }
}