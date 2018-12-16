using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CalculatorCode.Models;

namespace CalculatorCode.Controllers
{
    public class TimeCalculatorController : Controller
    {
        public const String AlgorithmCode =
@"
public TimeSpan CalculateResult (DateTime InputOne, DateTime InputTwo)
{
    if (InputOne > InputTwo)
    {
        return InputTwo - InputOne;
    }
    else 
    {
        return InputTwo - InputOne;
    }

}
";
        public IActionResult Index()
        {
            ViewBag.Code = AlgorithmCode;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(TimeCalculatorModel model)
        {
            ViewBag.Code = AlgorithmCode;
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
    }
}