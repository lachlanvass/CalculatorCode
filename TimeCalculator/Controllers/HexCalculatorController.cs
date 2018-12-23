using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CalculatorCode.Models;

namespace CalculatorCode.Controllers
{
    public class HexCalculatorController : Controller
    {
        public IActionResult Index()
        {
            SetViewBagValues();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(HexCalculator model)
        {
            SetViewBagValues();
            if (!ModelState.IsValid)
            {
                return View();
            }

            String selectedValue = model.SelectedOperation;

            switch (selectedValue)
            {
                case "Add":
                    model.ResultInAltBase = model.AdditionResultInHex();
                    model.ResultInDecimal = model.AdditionResultInDecimal();
                    break;
                case "Subtract":
                    model.ResultInAltBase = model.SubtractionResultInHex();
                    model.ResultInDecimal = model.SubtractionResultInDecimal();
                    break;
                case "Multiply":
                    model.ResultInAltBase = model.MultiplicationResultInHex();
                    model.ResultInDecimal = model.MultiplicationResultInDecimal();
                    break;
                case "Divide":
                    model.ResultInAltBase = model.DivisionResultInHex();
                    model.ResultInDecimal = model.DivisionResultInDecimal();
                    break;
            }

            return View(model);
        }


        public void SetViewBagValues()
        {
            ViewBag.Code = AlgorithmCode;
            ViewBag.Instructions = "Calculate Two Hexadecimal Values";
        }

        private String AlgorithmCode =
@"public static String CalculateAdditionResultInAltBase(String inputOne, String inputTwo, int baseNumber)
        {
            int inputOneInt = Convert.ToInt32(inputOne, baseNumber);
            int inputTwoInt = Convert.ToInt32(inputTwo, baseNumber);

            int sum = inputOneInt + inputTwoInt;

            // Convert back to binary
            String result = Convert.ToString(sum, baseNumber);
            return result;
        }
        public static String CalculateSubtractionResultInAltBase(String inputOne, String inputTwo, int baseNumber)
        {
            int inputOneInt = Convert.ToInt32(inputOne, baseNumber);
            int inputTwoInt = Convert.ToInt32(inputTwo, baseNumber);

            int sum = inputOneInt - inputTwoInt;

            // Convert back to binary
            String result = Convert.ToString(sum, baseNumber);
            return result;
        }

        public static String CalculateMultiplicationResultInAltBase(String inputOne, String inputTwo, int baseNumber)
        {
            int inputOneInt = Convert.ToInt32(inputOne, baseNumber);
            int inputTwoInt = Convert.ToInt32(inputTwo, baseNumber);

            int sum = inputOneInt * inputTwoInt;

            // Convert back to binary
            String result = Convert.ToString(sum, baseNumber);
            return result;
        }

        public static String CalculateDivisionResultInAltBase(String inputOne, String inputTwo, int baseNumber)
        {
            int inputOneInt = Convert.ToInt32(inputOne, baseNumber);
            int inputTwoInt = Convert.ToInt32(inputTwo, baseNumber);

            int sum = inputOneInt / inputTwoInt;

            // Convert back to binary
            String result = Convert.ToString(sum, baseNumber);
            return result;
        }


        public static int CalculateAdditionResultInDecimal(String inputOne, String inputTwo, int baseNumber)
        {
            // Convert binary strings to decimal integers
            int inputOneInt = Convert.ToInt32(inputOne, baseNumber);
            int inputTwoInt = Convert.ToInt32(inputTwo, baseNumber);
            return inputOneInt + inputTwoInt;
        }

        public static int CalculateSubtractionResultInDecimal(String inputOne, String inputTwo, int baseNumber)
        {
            // Convert binary strings to decimal integers
            int inputOneInt = Convert.ToInt32(inputOne, baseNumber);
            int inputTwoInt = Convert.ToInt32(inputTwo, baseNumber);
            return inputOneInt - inputTwoInt;
        }

        public static int CalculateMultiplicationResultInDecimal(String inputOne, String inputTwo, int baseNumber)
        {
            // Convert binary strings to decimal integers
            int inputOneInt = Convert.ToInt32(inputOne, baseNumber);
            int inputTwoInt = Convert.ToInt32(inputTwo, baseNumber);
            return inputOneInt * inputTwoInt;
        }
        public static int CalculateDivisionResultInDecimal(String inputOne, String inputTwo, int baseNumber)
        {
            // Convert binary strings to decimal integers
            int inputOneInt = Convert.ToInt32(inputOne, baseNumber);
            int inputTwoInt = Convert.ToInt32(inputTwo, baseNumber);
            return inputOneInt / inputTwoInt;
        }";
    }
}