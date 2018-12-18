using System;

namespace CalculatorCode.Models
{
    public class TimeCalculatorModel : Calculator
    {
        new public DateTime InputOne { get; set; }
        new public DateTime InputTwo { get; set; }
        new public TimeSpan Result { get; set; }
        public String Name = "TimeCalculator";

        public TimeSpan CalculateTimeSpanResult()
        {
            return InputTwo - InputOne;
        }

        public TimeSpan CalculateResultReverse()
        {
            return InputOne - InputTwo;
        }
    }
}
