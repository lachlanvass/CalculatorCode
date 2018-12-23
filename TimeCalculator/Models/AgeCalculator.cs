using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorCode.Models
{
    public class AgeCalculator : Calculator
    {
        new public DateTime InputOne { get; set; }
        new public TimeSpan Result;

        public TimeSpan CalculateAge()
        {
            return DateTime.Now - InputOne;
        }
    }
}
