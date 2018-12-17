using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorCode.Models
{
    public class SimpleCalculator : Calculator
    {
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Please enter a valid number")]
        new public int InputOne { get; set; }

        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Please enter a valid number")]
        new public int InputTwo { get; set; }

        new public int Result { get; set; }
        public String Name = "SimpleCalculator";

        public int CalculateResult()
        {
            return InputOne + InputTwo;
        }
    }
}
