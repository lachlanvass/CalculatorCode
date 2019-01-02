using System;
using Microsoft.AspNetCore.Mvc;
using CalculatorCode.Models;

namespace CalculatorCode.Controllers
{
    public class GCDandLCMCalculatorController : Controller
    {

        public IActionResult Index()
        {
            SetViewBagValues();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(GCDandLCMCalculator model)
        {
            SetViewBagValues();
            if (!ModelState.IsValid)
            {
                return View();
            }

            model.GCDResult = model.CalculateGCD();
            model.LCMResult = model.CalculateLCM();


            return View(model);
        }

        public void SetViewBagValues()
        {
            ViewBag.Code = AlgorithmCode;
            ViewBag.Instructions = "Calculate the GCD and LCD (LCM) of two values";
        }

        public const String AlgorithmCode =
@"public Double CalculateGCD(Double inputOne, Double inputTwo)
    {
        inputOne = Math.Abs(inputOne);
        inputTwo = Math.Abs(inputTwo);

        for (; ; )
        {
            Double remainder = inputOne % inputTwo;
            if (remainder == 0) return inputTwo;
            inputOne = inputTwo;
            inputTwo = remainder;
        }
    }

public Double CalculateLCM(Double inputOne, Double inputTwo)
    {
        return inputOne * inputTwo / this.CalculateGCD(inputOne, inputTwo);
    }

";
    }
}