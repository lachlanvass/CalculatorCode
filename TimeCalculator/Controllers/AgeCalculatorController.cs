using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CalculatorCode.Models;

namespace CalculatorCode.Controllers
{
    public class AgeCalculatorController : Controller
    {
        public IActionResult Index()
        {
            SetViewBagValues();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(AgeCalculator model)
        {
            SetViewBagValues();
            if (!ModelState.IsValid)
            {
                return View();
            }            

            model.Result = model.CalculateAge();
            return View(model);
        }


        public void SetViewBagValues()
        {
            ViewBag.Code = AlgorithmCode;
            ViewBag.Instructions = "Enter your birthdate. See how many days old you are";

        }

        private String AlgorithmCode =
@"public TimeSpan CalculateAge(DateTime InputOne)
{
    return DateTime.Now - InputOne;
}";
    }

}