using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CalculatorCode.Models
{
    public class PermutationsCalculator : Calculator
    {
        [Display(Name = "Number of Objects (n)")]
        public int NumberOfObjects { get; set; }

        [Display(Name = "Sample Size (r)")]
        public int SampleSize { get; set; }
        new public long Result { get; set; }

        public long CalculateResult()
        {
            return Permutations(NumberOfObjects, SampleSize);
        }

        public static long Permutations(int noOjObjects, int noChosen)
        {
            return FactorialDivision(noOjObjects, noOjObjects - noChosen);
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