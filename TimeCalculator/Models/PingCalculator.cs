
using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CalculatorCode.Models
{
    public class PingCalculator : Calculator
    {
        [RegularExpression(@"^$", ErrorMessage = "Please enter a valid number")]
        new public int InputOne { get; set; }

        [RegularExpression(@"^$", ErrorMessage = "Please enter a valid number")]
        new public int InputTwo { get; set; }
        new public int Result { get; set; }
        public SelectList Operations = new SelectList("Add", "Subtract", "Multiply", "Divide");

        public String SelectedOperation { get; set; }
 
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

    }

}