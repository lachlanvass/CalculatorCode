using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

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