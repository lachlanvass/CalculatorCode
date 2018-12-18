using System;
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
        public String SelectedOperation { get; set; }
        public String CalculateAdditionResultInBinary()
        {
            String result;
            result = BinaryValue.SumInBinaryFromStrings(InputOne, InputTwo);
            return result;
        }

        public int CalculateAdditionResultInDecimal()
        {
            int result;
            result = BinaryValue.SumInDecimalFromStrings(InputOne, InputTwo);
            return result;
        }

        public String CalculateSubtractionResultInBinary()
        {
            String result;
            result = BinaryValue.SubtractionInBinaryFromStrings(InputOne, InputTwo);
            return result;
        }

        public int CalculateSubtractionResultInDecimal()
        {
            int result;
            result = BinaryValue.SubtractionInDecimalFromStrings(InputOne, InputTwo);
            return result;
        }

        public String CalculateMultiplicationResultInBinary()
        {
            String result;
            result = BinaryValue.MultiplyInBinaryFromStrings(InputOne, InputTwo);
            return result;
        }

        public int CalculateMultiplicationResultInDecimal()
        {
            int result;
            result = BinaryValue.MultiplyInDecimalFromStrings(InputOne, InputTwo);
            return result;
        }

        public String CalculateDivisionResultInBinary()
        {
            String result;
            result = BinaryValue.DivisionInBinaryFromStrings(InputOne, InputTwo);
            return result;
        }

        public int CalculateDivisionResultInDecimal()
        {
            int result;
            result = BinaryValue.DivisionInDecimalFromStrings(InputOne, InputTwo);
            return result;
        }


        // Output result in both binary and decimal
    }
}
