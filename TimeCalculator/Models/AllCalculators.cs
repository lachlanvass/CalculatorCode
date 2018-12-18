using System.Collections.Generic;

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
