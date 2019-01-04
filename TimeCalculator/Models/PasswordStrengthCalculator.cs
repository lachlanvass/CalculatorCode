using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CalculatorCode.Models
{
    public class PasswordStrengthCalculator : Calculator
    {
        // Make this client-side to ensure password security
        [RegularExpression(@"^$", ErrorMessage = "Please enter a valid number")]
        public int PasswordInput { get; set; }
        private readonly long CrackingAttemptsPerHour;
        new public int Result { get; set; }
 
       

    }

}