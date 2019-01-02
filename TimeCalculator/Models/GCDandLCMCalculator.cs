using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CalculatorCode.Models
{
    public class GCDandLCMCalculator : Calculator
    { 
        // Validate inputs
        new public Double InputOne { get; set; }

        new public Double InputTwo { get; set; }
        public Double LCMResult { get; set; }
        public Double GCDResult { get; set; }

        public String SelectedOperation { get; set; }

        public Double CalculateGCD()
        {
            InputOne = Math.Abs(InputOne);
            InputTwo = Math.Abs(InputTwo);

            for (; ; )
            {
                Double remainder = InputOne % InputTwo;
                if (remainder == 0) return InputTwo;
                InputOne = InputTwo;
                InputTwo = remainder;
            }
        }
        public Double CalculateGCD(Double inputOne, Double inputTwo)
        {
            inputOne = Math.Abs(inputOne);
            inputTwo = Math.Abs(inputTwo);

            for (; ; )
            {
                Double remainder = inputOne % inputTwo;
                if (remainder == 0) return inputTwo;
                inputOne = inputTwo;
                inputTwo = remainder;
            }
        }


        public Double CalculateLCM(Double inputOne, Double inputTwo)
        {
            return inputOne * inputTwo / this.CalculateGCD(inputOne, inputTwo);
        }

        public Double CalculateLCM()
        {
            return InputOne * InputTwo / this.CalculateGCD(InputOne, InputTwo);
        }

    }

}