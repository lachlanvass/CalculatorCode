using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorCode.Controllers
{
    public class AdController : Controller
    {
        // Must place ads.txt at root domain
        public IActionResult Index()
        {
            String adsTxtPath = "~\ads.txt";
            return View(adsTxtPath);
        }
    }
}