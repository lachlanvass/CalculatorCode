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
            ViewBag.Instruction = "Add two binary numbers";
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(BinaryCalculator model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            model.ResultInBinary = model.CalculateResultInBinary();
            model.ResultInDecimal = model.CalculateResultInDecimal();
            return View(model);
        }
    }
}