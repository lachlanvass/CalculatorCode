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

            String selectedValue = model.SelectedOperation;

            switch(selectedValue)
            {
                case "Add"      : 
                                break;
                case "Subtract" : 
                                break;
                case "Multiply" : 
                                break;
                case "Divide": 
                            break;
            }

            return View(model);
        }

        public void SetViewBagValues()
        {
            ViewBag.Code = AlgorithmCode;
            ViewBag.Instructions = "INSERT INSTRUCTIONS HERE";
        }

        public const String AlgorithmCode =
@"INSERT CODE HERE";
    }
}