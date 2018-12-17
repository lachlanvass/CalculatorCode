using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorCode.Models
{
    public class CircleCircumferenceRadiusCalculator : Calculator
    {
        [DisplayName("Radius")]
        new public int InputOne { get; set; }
        new public Double Result { get; set; }
        public String Name = "Circle Circumferance Calculator From Radius";

        public Double CalculateCircumferanceFromRadius()
        {
            Double radius = InputOne;
            // (Pi * r) * 2
            Double circumferance = (Math.PI * radius) * 2;

            return circumferance;
        }

    }
}
