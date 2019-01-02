using System;
using Microsoft.AspNetCore.Mvc;
using CalculatorCode.Models;

namespace CalculatorCode.Controllers
{
    public class CompoundInterestCalculatorController : Controller
    {

        public IActionResult Index()
        {
            SetViewBagValues();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(CompoundInterestCalculator model)
        {
            SetViewBagValues();
            if (!ModelState.IsValid)
            {
                return View();
            }

            String compoundFrequency = model.SelectedCompoundedFrequency;
            switch (compoundFrequency)
            {
                case "Daily": model.CompoundFrequencyPerYear = 365;
                    break;
                case "Weekly": model.CompoundFrequencyPerYear = 52;
                    break;
                case "Fortnightly": model.CompoundFrequencyPerYear = 26;
                    break;
                case "Monthly": model.CompoundFrequencyPerYear = 12;
                    break;
                case "Quarterly": model.CompoundFrequencyPerYear = 4;
                    break;
                case "SemiAnnually": model.CompoundFrequencyPerYear = 2;
                    break;
                case "Yearly": model.CompoundFrequencyPerYear = 1;
                    break;
            }

            model.TotalAccrued = model.CalculateAccruedAmount();



            return View(model);
        }

        public void SetViewBagValues()
        {
            ViewBag.Code = AlgorithmCode;
            ViewBag.Instructions = "Calculate Accrued Compound Interest (Principal + Interest)";
        }

        public const String AlgorithmCode =
@"public Double CalculateAccruedAmount()
{
    // A = P(1 + r/n)^nt
    Double result = PrincipalInput * Math.Pow((1 + InterestRateInput / CompoundFrequencyPerYear), CompoundFrequencyPerYear * TimeInYears);
    return result;
}";
    }
}