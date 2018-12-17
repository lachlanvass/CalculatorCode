using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorCode.Models
{
    public class BinaryCalculator : Calculator
    {
        new public BinaryValue InputOne { get; set; }
        new public BinaryValue InputTwo { get; set; }
        public String ResultInBinary { get; set; }
        public int ResultInDecimal { get; set; }


        public String CalculateResultInBinary()
        {
            String result;
            result = BinaryValue.SumInBinary(InputOne, InputTwo);
            return result;
        }

        public int CalculateResultInDecimal()
        {
            int result;
            result = BinaryValue.SumInDecimal(InputOne, InputTwo);
            return result;
        }


        // Output result in both binary and decimal
    }
}
