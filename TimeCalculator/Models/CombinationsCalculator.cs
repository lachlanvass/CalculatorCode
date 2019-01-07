using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CalculatorCode.Models
{
    public class CombinationsCalculator : Calculator
    {
        [Display(Name = "Number of Objects (n)")]
        public int NumberOfObjects { get; set; }

        [Display(Name = "Sample Size (r)")]
        public int SampleSize { get; set; }
        new public long Result { get; set; }

        public long CalculateResult()
        {
            return Combinations(NumberOfObjects, SampleSize);
        }

        public static long Combinations(int noOfObjects, int noChosen)
        {
            return Permutations(noOfObjects, noChosen) / Factorial(noChosen);
        }

        private static long Permutations(int noOjObjects, int noChosen)
        {
            return FactorialDivision(noOjObjects, noOjObjects - noChosen);
        }

        private static long Factorial(int i)
        {
            if (i <= 1)
                return 1;
            return i * Factorial(i - 1);
        }

        private static long FactorialDivision(int topFactorial, int divisorFactorial)
        {
            long result = 1;
            for (int i = topFactorial; i > divisorFactorial; i--)
            {
                result = result * i;
            }
            return result;
        }


    }

}