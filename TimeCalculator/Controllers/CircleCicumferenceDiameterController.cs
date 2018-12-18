using System;
using Microsoft.AspNetCore.Mvc;
using CalculatorCode.Models;

namespace CalculatorCode.Controllers
{
    public class CircleCircumferenceDiameterController : Controller
    {

        public String AlgorithmCode =
@"public Double CalculateCircumferanceFromDiameter()
{
    Double diamater = InputOne;
    Double circumferance = Math.PI * diamater;
    return circumferance;
}";
        public IActionResult Index()
        {
            ViewBag.Code = AlgorithmCode;
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(CircleCircumferenceDiameterCalculator model)
        {
            ViewBag.Code = AlgorithmCode;
            model.Result = model.CalculateCircumferanceFromDiameter();
            return View(model);
        }
    }
}