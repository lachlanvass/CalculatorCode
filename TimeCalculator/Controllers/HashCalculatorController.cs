using System;
using Microsoft.AspNetCore.Mvc;
using CalculatorCode.Models;
using System.Reflection;

namespace CalculatorCode.Controllers
{
    public class HashCalculatorController : Controller
    {

        public IActionResult Index()
        {
            SetViewBagValues();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(HashCalculator model)
        {
            SetViewBagValues();
            if (!ModelState.IsValid)
            {
                return View();
            }

            String selectedValue = model.SelectedAlgorithm;

            switch (selectedValue)
            {
                case "SHA1": model.Result = model.ComputeSHA1Hash(); break;
                case "SHA256": model.Result = model.ComputeSHA256Hash(); break;
                case "SHA384": model.Result = model.ComputeSHA384Hash(); break;
                case "SHA512": model.Result = model.ComputeSHA512Hash(); break;
                case "MD5": model.Result = model.ComputeMD5Hash(); break;
            }

            return View(model);
        }

        public void SetViewBagValues()
        {
            ViewBag.Code = AlgorithmCode;
            ViewBag.Instructions = "Calculate the Hashed Value of Text";
        }

        public const String AlgorithmCode =
@"public String ComputeSHA256Hash()
    {
 
        using (SHA256 sha256Hash = SHA256.Create())
        {
            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(InputOne));
            StringBuilder builder = bytesToStringBuilder(bytes);
            return builder.ToString();
        }
    }

    public String ComputeSHA1Hash()
    {

        using (SHA1 shaHash = SHA1.Create())
        {
            byte[] bytes = shaHash.ComputeHash(Encoding.UTF8.GetBytes(InputOne));
            StringBuilder builder = bytesToStringBuilder(bytes);
            return builder.ToString();
        }
    }

    public String ComputeSHA512Hash()
    {
        using (SHA512 shaHash = SHA512.Create())
        {
            byte[] bytes = shaHash.ComputeHash(Encoding.UTF8.GetBytes(InputOne));
            StringBuilder builder = bytesToStringBuilder(bytes);
            return builder.ToString();
        }
    }

    public String ComputeSHA384Hash()
    {
        using (SHA384 shaHash = SHA384.Create())
        {
            byte[] bytes = shaHash.ComputeHash(Encoding.UTF8.GetBytes(InputOne));
            StringBuilder builder = bytesToStringBuilder(bytes);
            return builder.ToString();
        }
    }

    public String ComputeMD5Hash()
    {

        using (MD5 shaHash = MD5.Create())
        {
            byte[] bytes = shaHash.ComputeHash(Encoding.UTF8.GetBytes(InputOne));
            StringBuilder builder = bytesToStringBuilder(bytes);
            return builder.ToString();
        }
    }

    private StringBuilder bytesToStringBuilder(byte[] bytes)
    {
        StringBuilder builder = new StringBuilder();
        foreach (byte b in bytes)
        {
            builder.Append(b.ToString(""x2""));
        }

        return builder;
    }";
    }
}