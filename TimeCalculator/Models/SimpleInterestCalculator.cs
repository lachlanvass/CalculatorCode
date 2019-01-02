using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CalculatorCode.Models
{
    public class SimpleInterestCalculator : Calculator
    {
        [Display(Name = "Principal ($)")]
        public Double PrincipalInput { get; set; }
        [Display(Name = "Interest Rate (%)")]
        public Double InterestRateInput { get; set; }
        [Display(Name = "Time (years)")]
        public Double TimeInYears { get; set; }

        public Double TotalAccrued { get; set; }

        public Double CalculateAccruedAmount(Double principal, Double interestRate, int numberOfTermsPerTime, Double time)
        {
            return Math.Pow(principal * (1 + (interestRate / numberOfTermsPerTime)),
                numberOfTermsPerTime * time);
        }

        public Double CalculateAccruedAmount()
        {
            // A = P(1 + r/n)^nt
            // Convert Interest rate to percentage
            InterestRateInput = InterestRateInput / 100;
            Double result = PrincipalInput * (1 + InterestRateInput * TimeInYears);
            return result;
        }

    }


}