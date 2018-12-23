using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CalculatorCode.Models
{
    public class HexCalculator : AltBaseCalculator
    {
        [RegularExpression(@"^[0-9 A-F a-f]+$", ErrorMessage = "Please use a valid Hexadecimal value")]
        new public String InputOne {get; set;}
        [RegularExpression(@"^[0-9 A-F a-f]+$", ErrorMessage = "Please use a valid Hexadecimal value")]
        new public String InputTwo { get; set; }
        new public String ResultInAltBase { get; set; }
        new public int ResultInDecimal { get; set; }

        public String AdditionResultInHex()
        {
            return CalculateAdditionResultInAltBase(InputOne, InputTwo, 16);
        }

        public String SubtractionResultInHex()
        {
            return CalculateSubtractionResultInAltBase(InputOne, InputTwo, 16);
        }

        public String MultiplicationResultInHex()
        {
            return CalculateMultiplicationResultInAltBase(InputOne, InputTwo, 16);
        }

        public String DivisionResultInHex()
        {
            return CalculateDivisionResultInAltBase(InputOne, InputTwo, 16);        
        }

        public int AdditionResultInDecimal()
        {
            return CalculateAdditionResultInDecimal(InputOne, InputTwo, 16);
        }

        public int SubtractionResultInDecimal()
        {
            return CalculateSubtractionResultInDecimal(InputOne, InputTwo, 16);
        }

        public int MultiplicationResultInDecimal()
        {
            return CalculateMultiplicationResultInDecimal(InputOne, InputTwo, 16);
        }

        public int DivisionResultInDecimal()
        {
            return CalculateDivisionResultInDecimal(InputOne, InputTwo, 16);
        }
    }
}

