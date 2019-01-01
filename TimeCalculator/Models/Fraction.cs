using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorCode.Models
{
    public class Fraction
    {
        public Double Numerator { get; set; }
        public Double Denonmenator { get; set; }

        public Fraction () { /* Default constructor */ }
        public Fraction (Double numerator, Double denomenator)
        {
            Numerator = numerator;
            Denonmenator = denomenator;
        }

        public Double Resolve()
        {
            return Numerator / Denonmenator;
        }
        public static Double Resolve(Fraction input)
        {
            return input.Numerator / input.Denonmenator;
        }

        public static Fraction operator + (Fraction lhs, Fraction rhs)
        {
            Fraction result = new Fraction();

            if (lhs.Denonmenator == rhs.Denonmenator)
            {
                Double newNumerator = lhs.Numerator + rhs.Numerator;
                result.Denonmenator = lhs.Denonmenator;
                result.Numerator = rhs.Numerator;
                return result;
            }
            else
            {
                //Double lcd = Fraction.LCD(lhs.Denonmenator, rhs.Denonmenator);
                 
                return result;
            }
        }


        //private static long GCD(Double a, Double b)
        //{
        //    a = Math.Abs(a);
        //    b = Math.Abs(b);

        //    for (; ; )
        //    {
        //        Double remainder = a % b;
        //        if (remainder == 0) return b;
        //        a = b;
        //        b = remainder;
        //    }
        //}

        //public static long LCD(Double a, Double b)
        //{
           
        //    return a * b / Fraction.GCD(a, b);
        //}


    }
}
