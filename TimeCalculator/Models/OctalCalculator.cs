using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CalculatorCode.Models
{
    public class OctalCalculator : AltBaseCalculator
    {
        [RegularExpression(@"^[0-7]+$", ErrorMessage = "Please use a valid Octal value")]
        new public String InputOne { get; set; }
        [RegularExpression(@"^[0-7]+$", ErrorMessage = "Please use a valid Octal value")]
        new public String InputTwo { get; set; }
        new public String ResultInAltBase { get; set; }
        new public int ResultInDecimal { get; set; }

        public String AdditionResultInOctal()
        {
            return CalculateAdditionResultInAltBase(InputOne, InputTwo, 8);
        }

        public String SubtractionResultInOctal()
        {
            return CalculateSubtractionResultInAltBase(InputOne, InputTwo, 8);
        }

        public String MultiplicationResultInOctal()
        {
            return CalculateMultiplicationResultInAltBase(InputOne, InputTwo, 8);
        }

        public String DivisionResultInOctal()
        {
            return CalculateDivisionResultInAltBase(InputOne, InputTwo, 8);
        }

        public int AdditionResultInDecimal()
        {
            return CalculateAdditionResultInDecimal(InputOne, InputTwo, 8);
        }

        public int SubtractionResultInDecimal()
        {
            return CalculateSubtractionResultInDecimal(InputOne, InputTwo, 8);
        }

        public int MultiplicationResultInDecimal()
        {
            return CalculateMultiplicationResultInDecimal(InputOne, InputTwo, 8);
        }

        public int DivisionResultInDecimal()
        {
            return CalculateDivisionResultInDecimal(InputOne, InputTwo, 8);
        }
    }
}
