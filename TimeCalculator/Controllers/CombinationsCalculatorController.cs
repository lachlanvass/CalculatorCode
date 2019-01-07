using System;
using Microsoft.AspNetCore.Mvc;
using CalculatorCode.Models;

namespace CalculatorCode.Controllers
{
    public class CombinationsCalculatorController : Controller
    {

        public IActionResult Index()
        {
            SetViewBagValues();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(CombinationsCalculator model)
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
            ViewBag.Instructions = "Calculate Number of Combinations";
        }

        public const String AlgorithmCode =
@"
public static long Combinations(int noOfObjects, int noChosen)
{
    return Permutations(noOfObjects, noChosen) / Factorial(noChosen);
}

private static long Permutations(int noOjObjects, int noChosen)
{
    return FactorialDivision(noOjObjects, noOjObjects - noChosen);
}

private static long Factorial(int i)
{
    if (i <= 1)
        return 1;
    return i * Factorial(i - 1);
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