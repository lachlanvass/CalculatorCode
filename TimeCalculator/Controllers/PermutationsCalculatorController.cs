using System;
using Microsoft.AspNetCore.Mvc;
using CalculatorCode.Models;

namespace CalculatorCode.Controllers
{
    public class PermutationsCalculatorController : Controller
    {

        public IActionResult Index()
        {
            SetViewBagValues();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(PermutationsCalculator model)
        {
            SetViewBagValues();
            if (!ModelState.IsValid)
            {
                return View();
            }

            if (model.NumberOfObjects < model.SampleSize || model.NumberOfObjects < 0)
            {
                model.Result = 0;
            }
            else
            {
                model.Result = model.CalculateResult();
            }


            return View(model);
        }

        public void SetViewBagValues()
        {
            ViewBag.Code = AlgorithmCode;
            ViewBag.Instructions = "Calculate Total Number of Permutations";
        }

        public const String AlgorithmCode =
@"
public static long Permutations(int noOjObjects, int noChosen)
{
    return FactorialDivision(noOjObjects, noOjObjects - noChosen);
}

private static long FactorialDivision(int topFactorial, int divisorFactorial)
{
    long result = 1;
    for (int i = topFactorial; i > divisorFactorial; i--)
    {
        result = result * i;
    }
    return result;
}
";
    }
}