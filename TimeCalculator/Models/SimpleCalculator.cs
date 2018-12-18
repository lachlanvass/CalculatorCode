using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CalculatorCode.Models
{
    public class SimpleCalculator : Calculator
    {
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Please enter a valid number")]
        new public int InputOne { get; set; }

        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Please enter a valid number")]
        new public int InputTwo { get; set; }
        new public int Result { get; set; }
        public SelectList Operations = new SelectList("Add", "Subtract", "Multiply", "Divide");

        public String SelectedOperation { get; set; }

        public String Name = "SimpleCalculator";
 
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

    public enum Operations
    {
        Add,
        Subtract,
        Multiply,
        Divide
    }
}
