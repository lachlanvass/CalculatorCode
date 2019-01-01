using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CalculatorCode.Models
{
    public class InformationCalculator : Calculator
    {
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Please enter a valid number")]
        new public long InputOne { get; set; }
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Please enter a valid number")]
        new public long InputTwo { get; set; }
        public long ResultInBits { get; set; }
        public long ResultInBytes { get; set; }
        public long ResultInKiloBytes { get; set; }
        public long ResultInMegaBytes { get; set; }
        public long ResultInGigaBytes { get; set; }
        public long ResultInTeraBytes { get; set; }
        public String SelectedUnitInputOne { get; set; }
        public String SelectedUnitInputTwo { get; set; }
        public String SelectedOperation { get; set; }

        public long ConvertInputToBits(long input, String inputUnit)
        {
            long result;

            switch (inputUnit)
            {
                case "Bits": break;
                case "Bytes": input = input * 8; break;
                case "Kilobytes": input = input * 8000; break;
                case "Megabytes": input = input * 800000; break;
                case "Gigabytes": input = input * 800000000; break;
                case "Terabytes": input = input * 800000000000; break;
            }

            result = input;
            return result;
        }

        public long CalculateAdditionResult()
        {
            return InputOne + InputTwo;
        }

        public long CalculateSubtractionResult()
        {
            return InputOne - InputTwo;
        }

    }


    // Use as options for dropdown menus in InformatationCalculator/Index.cshtml
    public enum InformationUnits
    {
        Bits,
        Bytes,
        Kilobytes,
        Megabytes,
        Gigabytes,
        Terabytes
    }

    public enum InformationOperations
    {
        Add,
        Subtract,
    }

}