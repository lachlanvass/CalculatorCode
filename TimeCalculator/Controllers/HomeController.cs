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
            foreach (string s in adsTxt)
                builder.Append(s + "\n");
            return Content(builder.ToString());
        }
        
    }
}
