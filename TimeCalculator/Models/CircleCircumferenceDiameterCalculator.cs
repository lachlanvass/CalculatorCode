using System;
using System.ComponentModel;

namespace CalculatorCode.Models
{
    public class CircleCircumferenceDiameterCalculator : Calculator
    {
        [DisplayName("Diameter")]
        new public int InputOne { get; set; }
        new public Double Result { get; set; }
        public String Name = "Circle Circumferance Calculator From Diamter";

        public Double CalculateCircumferanceFromDiameter()
        {
            Double diamater = InputOne;
            Double circumferance = Math.PI * diamater;
            return circumferance;
        }
    }
}