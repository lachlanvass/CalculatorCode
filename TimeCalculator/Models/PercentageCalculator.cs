using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CalculatorCode.Models
{
    public class PercentageCalculator : Calculator
    {
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Please enter a valid number")]
        new public Double InputOne { get; set; }

        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Please enter a valid number")]
        new public Double InputTwo { get; set; }
        new public Double Result { get; set; }

        public String SelectedOperation { get; set; }

        public double PercentageOf()
        {
            double result = InputOne * (InputTwo / 100);
            return result;
        }

        public double PercentageDifference()
        {
            double difference = InputTwo - InputOne;
            double decimalDifference = difference / InputOne;
            double result = decimalDifference * 100;
            return result;
        }

}

    public enum PercentageOptions
    {
        PercentageOf,
        Difference
    }

    

}