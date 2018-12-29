using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CalculatorCode.Models;

namespace CalculatorCode.Controllers
{
    public class OctalCalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(OctalCalculator model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            String selectedValue = model.SelectedOperation;
            switch (selectedValue)
            {
                case "Add":
                    model.ResultInAltBase = model.AdditionResultInOctal();
                    model.ResultInDecimal = model.AdditionResultInDecimal();
                    break;
                case "Subtract":
                    model.ResultInAltBase = model.SubtractionResultInOctal();
                    model.ResultInDecimal = model.SubtractionResultInDecimal();
                    break;
                case "Multiply":
                    model.ResultInAltBase = model.MultiplicationResultInOctal();
                    model.ResultInDecimal = model.MultiplicationResultInDecimal();
                    break;
                case "Divide":
                    model.ResultInAltBase = model.DivisionResultInOctal();
                    model.ResultInDecimal = model.DivisionResultInDecimal();
                    break;
            }

            return View(model);
        }
    }
}