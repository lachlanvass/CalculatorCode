using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CalculatorCode.Models
{
    public class TextTokensCalculator : Calculator
    {
        new public String InputOne { get; set; }

        public Dictionary<char, int> TokenResult { get; set; }

        public Dictionary<Char, int> TokenizeString(String input)
        {
            // Char token followed by int frequency. 
            // Calculate unique token count?
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            // Split string into distinct tokens.
            var charGroups = (from symbol in input
                              group symbol by symbol into g
                              select new
                              {
                                  symbol = g.Key,
                                  count = g.Count()
                              }).OrderByDescending(symbol => symbol.count);
            foreach (var group in charGroups)
            {
                dictionary.Add(group.symbol, group.count);
            }
            return dictionary;
        }




    }

}