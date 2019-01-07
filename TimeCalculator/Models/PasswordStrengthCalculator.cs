using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CalculatorCode.Models
{
    public class PasswordStrengthCalculator : Calculator
    {
        // Make this client-side to ensure password security

        public String PasswordInput { get; set; }
        private readonly long CrackingAttemptsPerHour;
        new public int Result { get; set; }
        public Dictionary<char, int> SymbolsFrequency { get; set; }
        public long NumberOfCombinations { get; set; }
        // In addition to calculating how long it will take to crack password
        // Assess if password is weak, medium or strong

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

        internal void SetSymbolsFrequency()
        {
            SymbolsFrequency = TokenizeString(PasswordInput);
        }

        public long CalculatePasswordStrength(String input)
        {
            long result = 10;
            Dictionary<char, int> tokens = TokenizeString(input);
            int numberOfUniqueSymbols = tokens.Count;
            int totalCharacters = input.Length;
            return result;
        }


    }

}