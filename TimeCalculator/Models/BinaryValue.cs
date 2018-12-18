using System;

namespace CalculatorCode.Models
{
    public class BinaryValue
    {
        public String BinaryString { get; set; }
        private int BinaryInt { get; set; }
        public BinaryValue(String inputString)
        {
            BinaryString = inputString;
            BinaryInt = Convert.ToInt32(BinaryString, 2);
        }

        public static int SumInDecimal(BinaryValue inputOne, BinaryValue inputTwo)
        {
            return inputOne.BinaryInt + inputTwo.BinaryInt;
        }

        public static int SumInDecimalFromStrings(String inputOne, String inputTwo)
        {
            // Convert binary strings to decimal integers
            int inputOneInt = Convert.ToInt32(inputOne, 2);
            int inputTwoInt = Convert.ToInt32(inputTwo, 2);
            return inputOneInt + inputTwoInt;
        }

        public static int SubtractionInDecimalFromStrings(String inputOne, String inputTwo)
        {
            // Convert binary strings to decimal integers
            int inputOneInt = Convert.ToInt32(inputOne, 2);
            int inputTwoInt = Convert.ToInt32(inputTwo, 2);
            return inputOneInt - inputTwoInt;
        }

        public static int MultiplyInDecimalFromStrings(String inputOne, String inputTwo)
        {
            // Convert binary strings to decimal integers
            int inputOneInt = Convert.ToInt32(inputOne, 2);
            int inputTwoInt = Convert.ToInt32(inputTwo, 2);
            return inputOneInt * inputTwoInt;
        }

        public static int DivisionInDecimalFromStrings(String inputOne, String inputTwo)
        {
            // Convert binary strings to decimal integers
            int inputOneInt = Convert.ToInt32(inputOne, 2);
            int inputTwoInt = Convert.ToInt32(inputTwo, 2);
            return inputOneInt / inputTwoInt;
        }

        public static String SumInBinary(BinaryValue inputOne, BinaryValue inputTwo)
        {
            int sum = inputOne.BinaryInt + inputTwo.BinaryInt;
            String result = Convert.ToString(sum, 2);
            return result;

        }

        public static String SumInBinaryFromStrings(String inputOne, String inputTwo)
        {
            // Convert binary strings to decimal integers
            int inputOneInt = Convert.ToInt32(inputOne, 2);
            int inputTwoInt = Convert.ToInt32(inputTwo, 2);

            int sum = inputOneInt + inputTwoInt;

            // Convert back to binary
            String result = Convert.ToString(sum, 2);
            return result;

        }

        public static String SubtractionInBinaryFromStrings(String inputOne, String inputTwo)
        {
            // Convert binary strings to decimal integers
            int inputOneInt = Convert.ToInt32(inputOne, 2);
            int inputTwoInt = Convert.ToInt32(inputTwo, 2);

            int sum = inputOneInt - inputTwoInt;

            // Convert back to binary
            String result = Convert.ToString(sum, 2);
            return result;

        }

        public static String MultiplyInBinaryFromStrings(String inputOne, String inputTwo)
        {
            // Convert binary strings to decimal integers
            int inputOneInt = Convert.ToInt32(inputOne, 2);
            int inputTwoInt = Convert.ToInt32(inputTwo, 2);

            int sum = inputOneInt * inputTwoInt;

            // Convert back to binary
            String result = Convert.ToString(sum, 2);
            return result;

        }

        public static String DivisionInBinaryFromStrings(String inputOne, String inputTwo)
        {
            // Convert binary strings to decimal integers
            int inputOneInt = Convert.ToInt32(inputOne, 2);
            int inputTwoInt = Convert.ToInt32(inputTwo, 2);

            int sum = inputOneInt / inputTwoInt;

            // Convert back to binary
            String result = Convert.ToString(sum, 2);
            return result;

        }

        public static String ConvertToBinary(int input)
        {
            return Convert.ToString(input, 2);
        }
    }
}
