using System;
using Microsoft.AspNetCore.Mvc;
using CalculatorCode.Models;

namespace CalculatorCode.Controllers
{
    public class PercentageCalculatorController : Controller
    {

        public IActionResult Index()
        {
            SetViewBagValues();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(PercentageCalculator model)
        {
            SetViewBagValues();
            if (!ModelState.IsValid)
            {
                return View();
            }

            String selectedValue = model.SelectedOperation;

            switch (selectedValue)
            {
                case "PercentageOf" : model.Result = model.PercentageOf();
                    break;
                case "Difference"   : model.Result = model.PercentageDifference();
                    break;
            }

            return View(model);
        }

        public void SetViewBagValues()
        {
            ViewBag.Code = AlgorithmCode;
            ViewBag.Instructions = "Calculate Percentages Between Two Values";
        }

        public const String AlgorithmCode =
@"public double PercentageOf()
    {
        double result = InputOne * (InputTwo / 100);
        return result;
    }

    public double PercentageDifference()
    {
        double difference = InputTwo - InputOne;
        double decimalDifference = difference / InputOne;
        double result = decimalDifference * 100;
        return result;
    }
";
    }
}