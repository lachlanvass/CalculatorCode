using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculatorCode.Models;

namespace CalculatorCode.Models
{
    public class AllCalculators
    {

        public List<Calculator> CalculatorList = new List<Calculator>()
        {
            new TimeCalculatorModel(),
            new SimpleCalculator(),
            new CircleCircumferenceRadiusCalculator()
        };
    }
}
