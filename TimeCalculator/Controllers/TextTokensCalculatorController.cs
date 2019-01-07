using System;
using Microsoft.AspNetCore.Mvc;
using CalculatorCode.Models;

namespace CalculatorCode.Controllers
{
    public class TextTokensCalculatorController : Controller
    {

        public IActionResult Index()
        {
            SetViewBagValues();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(TextTokensCalculator model)
        {
            SetViewBagValues();
            if (!ModelState.IsValid)
            {
                return View();
            }

            model.TokenResult = model.TokenizeString(model.InputOne);

            return View(model);
        }

        public void SetViewBagValues()
        {
            ViewBag.Code = AlgorithmCode;
            ViewBag.Instructions = "Calculate the frequency of unique tokens in text";
        }

        public const String AlgorithmCode =
@"public Dictionary<Char, int> TokenizeString(String input)
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
    }";
    }
}