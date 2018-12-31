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
            String selectedOperation = model.SelectedOperation;
            long ResultInBits = new long();

            model.InputOne = model.ConvertInputToBits(model.InputOne, selectedUnitInputOne);
            model.InputTwo = model.ConvertInputToBits(model.InputTwo, selectedUnitInputTwo);


            switch (selectedOperation)
            {
                case "Add": ResultInBits = model.CalculateAdditionResult();
                    break;
                case "Subtract": ResultInBits = model.CalculateSubtractionResult();
                    break;
            }

            model.ResultInBits = ResultInBits;
            model.ResultInBytes = ResultInBits / 8;
            model.ResultInKiloBytes = ResultInBits / 8000;
            model.ResultInMegaBytes = ResultInBits / 800000;
            model.ResultInGigaBytes = ResultInBits / 800000000;
            model.ResultInTeraBytes = ResultInBits / 800000000000;

            return View(model);
        }

        public void SetViewBagValues()
        {
            ViewBag.Code = AlgorithmCode;
            ViewBag.Instructions = "Calculate units of information (Bytes, Kilobytes etc.)";
        }

        public const String AlgorithmCode =
@"public long ConvertInputToBits(long input, String inputUnit)
    {
        long result;

        switch (inputUnit)
        {
            case ""Bits"": break;
            case ""Bytes"": input = input* 8; break;
            case ""Kilobytes"": input = input* 8000; break;
            case ""Megabytes"": input = input* 800000; break;
            case ""Gigabytes"": input = input* 800000000; break;
            case ""Terabytes"": input = input* 800000000000; break;
        }

        result = input;
        return result;
    }

public long CalculateAdditionResult()
{
    return InputOne - InputTwo;
}

public long CalculateSubtractionResult()
{
    return InputOne - InputTwo;
}

";
    }
}