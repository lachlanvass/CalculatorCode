using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Text;

namespace CalculatorCode.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [Route("ads.txt")]
        public ContentResult AdsTxt()
        {
            // Must write full path for File - naming conflict with Microsoft.AspNetCore.Mvc;
            string[] adsTxt = System.IO.File.ReadAllLines(@"ads.txt");
            StringBuilder builder = new StringBuilder();
            for (byte i = 0; i < adsTxt.Length; i++)
                builder.Append(adsTxt[i] + "\n");
            return Content(builder.ToString());
        }
        
    }
}
