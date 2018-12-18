using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CalculatorCode.Models;

namespace CalculatorCode.Controllers
{
    public class SimpleCalculatorController : Controller
    {


        /*Steps to define new working Calulator View.
         * 1. Define model and algorithm
         * 2. Create view, create form sections for the various inputs
         * 3. Define an AlgorithmCode string expressing the algorithm needed to produce the output
         * 4. Insert that string into ViewBag.Code for the Controller methods which render the algoritm
         */

        public IActionResult Index()
        {
            SetViewBagValues(AlgorithmCode, Instructions);
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(SimpleCalculator model)
        {
            SetViewBagValues(AlgorithmCode, Instructions);

            if (!ModelState.IsValid)
            {
                return View();
            }
            string selectedOperation = model.SelectedOperation;
            Console.WriteLine("AAAA: " + selectedOperation);
            
            switch (selectedOperation)
            {
                case "Add": model.Result = model.CalculateAdditionResult(); break;
                case "Subtract": model.Result = model.CalculateSubtractionResult(); break;
                case "Multiply": model.Result = model.CalculateMultiplyResult(); break;
                case "Divide": model.Result = model.CalculateDivideResult(); break;
               
            }
            
            return View(model);
        }
       
        public void SetViewBagValues(String algorithmCode, String instructions)
        {
            ViewBag.Code = algorithmCode;
            ViewBag.Instructions = instructions;
        }

        public const String AlgorithmCode =
@"
public int CalculateAdditionResult()
{
    return InputOne + InputTwo;
}

public int CalculateSubtractionResult()
{
    return InputOne - InputTwo;
}

public int CalculateMultiplyResult()
{
    return InputOne * InputTwo;
}

public int CalculateDivideResult()
{
    return InputOne / InputTwo;
}
";

public const String Instructions = "Perform Operations on two numbers.";
    }
}