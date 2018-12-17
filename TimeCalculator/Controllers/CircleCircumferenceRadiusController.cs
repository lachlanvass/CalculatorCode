using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CalculatorCode.Models;

namespace CalculatorCode.Controllers
{
    public class CircleCircumferenceRadiusController : Controller
    {

        public const String AlgorithmCode =
@"public Double CalculateCircumferanceFromRadius()
{
    Double radius = InputOne;
    // (Pi * r) * 2
    Double circumferance = (Math.PI * radius) * 2;

    return circumferance;
}";
        public IActionResult Index()
        {
            ViewBag.Code = AlgorithmCode;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]      
        public IActionResult Index(CircleCircumferenceRadiusCalculator model)
        {
            ViewBag.Code = AlgorithmCode;
            model.Result = model.CalculateCircumferanceFromRadius();
            return View(model);
        }
    }
}