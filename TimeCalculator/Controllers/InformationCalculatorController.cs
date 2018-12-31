using System;
using Microsoft.AspNetCore.Mvc;
using CalculatorCode.Models;

namespace CalculatorCode.Controllers
{
    public class InformationCalculatorController : Controller
    {

        public IActionResult Index()
        {
            SetViewBagValues();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(InformationCalculator model)
        {
            SetViewBagValues();
            if (!ModelState.IsValid)
            {
                return View();
            }

            String selectedUnitInputOne = model.SelectedUnitInputOne;
            String selectedUnitInputTwo = model.SelectedUnitInputTwo;
            model.InputOne = model.ConvertInputToBits(model.InputOne, selectedUnitInputOne);
            model.InputTwo = model.ConvertInputToBits(model.InputTwo, selectedUnitInputTwo);

            long ResultInBits = model.CalculateAdditionResult();

            model.ResultInBits = ResultInBits;
            model.ResultInBytes = ResultInBits / 8;
            model.ResultInKiloBytes = ResultInBits / 8000;
            model.ResultInMegaBytes = ResultInBits / 800000;
            model.ResultInGigaBytes = ResultInBits / 800000000;
            model.ResultInTeraBytes = ResultInBits / 800000000000;

            //switch(selectedValue)
            //{
            //    case "Add"      : 
            //                    break;
            //    case "Subtract" : 
            //                    break;
            //    case "Multiply" : 
            //                    break;
            //    case "Divide": 
            //                break;
            //}

            return View(model);
        }

        public void SetViewBagValues()
        {
            ViewBag.Code = AlgorithmCode;
            ViewBag.Instructions = "Calculate units of information (Bytes, Kilobytes etc.)";
        }

        public const String AlgorithmCode =
@"INSERT CODE HERE";
    }
}