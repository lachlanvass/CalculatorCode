using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CalculatorCode.Models
{
    public class BinaryCalculator : Calculator
    {
        /* Inputs should only be 0's or 1's */ 
        [RegularExpression(@"^[0-1]+$", ErrorMessage = "Please enter only 0's or 1's")]
        new public String InputOne { get; set; }
        
        [RegularExpression(@"^[0-1]+$", ErrorMessage = "Please enter only 0's or 1's")]
        
        new public String InputTwo { get; set; }

        public String ResultInBinary { get; set; }
        public int ResultInDecimal { get; set; }


        public String CalculateResultInBinary()
        {
            String result;
            result = BinaryValue.SumInBinaryFromStrings(InputOne, InputTwo);
            return result;
        }

        public int CalculateResultInDecimal()
        {
            int result;
            result = BinaryValue.SumInDecimalFromStrings(InputOne, InputTwo);
            return result;
        }


        // Output result in both binary and decimal
    }
}
