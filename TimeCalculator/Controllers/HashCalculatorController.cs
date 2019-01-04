using System;
using Microsoft.AspNetCore.Mvc;
using CalculatorCode.Models;
using System.Reflection;

namespace CalculatorCode.Controllers
{
    public class HashCalculatorController : Controller
    {

        public IActionResult Index()
        {
            SetViewBagValues();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(HashCalculator model)
        {
            SetViewBagValues();
            if (!ModelState.IsValid)
            {
                return View();
            }

            String selectedValue = model.SelectedAlgorithm;

            switch (selectedValue)
            {
                case "SHA1": model.Result = model.ComputeSHA1Hash(); break;
                case "SHA256": model.Result = model.ComputeSHA256Hash(); break;
                case "SHA384": model.Result = model.ComputeSHA384Hash(); break;
                case "SHA512": model.Result = model.ComputeSHA512Hash(); break;
                case "MD5": model.Result = model.ComputeMD5Hash(); break;
            }

            return View(model);
        }

        public void SetViewBagValues()
        {
            ViewBag.Code = AlgorithmCode;
            ViewBag.Instructions = "Calculate the Hashed Value of Text";
        }

        public const String AlgorithmCode =
@"INSERT CODE HERE";
    }
}