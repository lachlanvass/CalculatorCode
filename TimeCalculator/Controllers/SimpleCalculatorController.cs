using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CalculatorCode.Models;

namespace CalculatorCode.Controllers
{
    public class SimpleCalculatorController : Controller
    {


        /*Steps to define new working Calulator View.
         * 1. Define model and algorithm
         * 2. Create view, create form sections for the various inputs
         * 3. Define an AlgorithmCode string expressing the algorithm needed to produce the output
         * 4. Insert that string into ViewBag.Code for the Controller methods which render the algoritm
         */

        public const String AlgorithmCode =
@"
public Double CalculateResult(Double InputOne, Double InputTwo)
{
    return InputOne + InputTwo
}
";
        public IActionResult Index()
        {
            ViewBag.Code = AlgorithmCode;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(SimpleCalculator model)
        {
            ViewBag.Code = AlgorithmCode;
            model.Result = model.CalculateResult();
            return View(model);

        }
    }
}