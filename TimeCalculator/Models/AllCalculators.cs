using System;
using System.Collections.Generic;


namespace CalculatorCode.Models
{
    public class AllCalculators
    {

        public SortedList<String, String> CalculatorList = new SortedList<String, String>();

        public AllCalculators()
        {
            CalculatorList.Add("Date Time Calculator", "TimeCalculator");
            CalculatorList.Add("Simple Calculator", "SimpleCalculator");
            CalculatorList.Add("Circle Circumferance From Radius Calculator", "CircleCircumferenceRadius");
            CalculatorList.Add("Circle Circumferance From Diameter Calculator", "CircleCircumferenceDiameter");
            CalculatorList.Add("Binary Calculator", "BinaryCalculator");
            CalculatorList.Add("Age Calculator", "AgeCalculator");
            CalculatorList.Add("Hex Calculator", "HexCalculator");
            CalculatorList.Add("Octal Calculator", "OctalCalculator");
        }
    }
}
