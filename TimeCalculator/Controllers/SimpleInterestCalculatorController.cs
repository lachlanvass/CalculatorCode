using System;
using Microsoft.AspNetCore.Mvc;
using CalculatorCode.Models;

namespace CalculatorCode.Controllers
{
    public class SimpleInterestCalculatorController : Controller
    {

        public IActionResult Index()
        {
            SetViewBagValues();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(SimpleInterestCalculator model)
        {
            SetViewBagValues();
            if (!ModelState.IsValid)
            {
                return View();
            }

            model.TotalAccrued = model.CalculateAccruedAmount();
            return View(model);
        }

        public void SetViewBagValues()
        {
            ViewBag.Code = AlgorithmCode;
            ViewBag.Instructions = "Calculate Accrued Simple Interest (Principal + Interest)";
        }

        public const String AlgorithmCode =
@"public Double CalculateAccruedAmount()
{
    // A = P(1 + r/n)^nt
    // Convert Interest rate to percentage
    InterestRateInput = InterestRateInput / 100;
    Double result = PrincipalInput * (1 + InterestRateInput * TimeInYears);
    return result;
}";
    }
}