using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CalculatorCode.Models;

namespace CalculatorCode.Controllers
{
    public class BinaryCalculatorController : Controller
    {

        public IActionResult Index()
        {
            SetViewBagValues();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(BinaryCalculator model)
        {
            SetViewBagValues();
            if (!ModelState.IsValid)
            {
                return View();
            }

            model.ResultInBinary = model.CalculateResultInBinary();
            model.ResultInDecimal = model.CalculateResultInDecimal();
            return View(model);
        }

        public void SetViewBagValues()
        {
            ViewBag.Code = AlgorithmCode;
            ViewBag.Instructions = "Add two binary values";
        }

        public const String AlgorithmCode =
@"public static String SumInBinaryFromStrings(String inputOne, String inputTwo)
    {
        // Convert binary strings to decimal integers
        int inputOneInt = Convert.ToInt32(inputOne, 2);
        int inputTwoInt = Convert.ToInt32(inputTwo, 2);

        int sum = inputOneInt + inputTwoInt;

        // Convert back to binary
        String result = Convert.ToString(sum, 2);
        return result;

    }

public static int SumInDecimalFromStrings(String inputOne, String inputTwo)
{
    // Convert binary strings to decimal integers
    int inputOneInt = Convert.ToInt32(inputOne, 2);
    int inputTwoInt = Convert.ToInt32(inputTwo, 2);
    return inputOneInt + inputTwoInt;
}

public String CalculateResultInBinary()
{
    String result;
    result = BinaryValue.SumInBinaryFromStrings(InputOne, InputTwo);
    return result;
}

public int CalculateResultInDecimal()
{
    int result;
    result = BinaryValue.SumInDecimalFromStrings(InputOne, InputTwo);
    return result;
}

";
    }
}