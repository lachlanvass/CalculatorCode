using System;
using Microsoft.AspNetCore.Mvc;
using CalculatorCode.Models;

namespace CalculatorCode.Controllers
{
    public class TimeCalculatorController : Controller
    {       
        public IActionResult Index()
        {
            SetViewBagData();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(TimeCalculatorModel model)
        {
            SetViewBagData();
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

        public void SetViewBagData()
        {
            ViewBag.Code = AlgorithmCode;
            ViewBag.Instructions = "Calculate distant between two dates and times";
        }

        public const String AlgorithmCode =
@"
public TimeSpan CalculateResult (DateTime InputOne, DateTime InputTwo)
{
    // Return absolute value
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
    }
}






