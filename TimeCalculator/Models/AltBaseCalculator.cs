using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorCode.Models
{
    public class AltBaseCalculator : Calculator
    {
        /* Calculate values that need conversion of bases other than base-10 */
        new public String InputOne { get; set; }

        new public String InputTwo { get; set; }
        public String ResultInAltBase { get; set; }
        public int ResultInDecimal { get; set; }
        public String SelectedOperation { get; set; }

        public static String CalculateAdditionResultInAltBase(String inputOne, String inputTwo, int baseNumber)
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
        }

    }
}
