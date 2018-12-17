using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorCode.Controllers
{
    public class StaticStateMethods : Controller
    {
        public void SetViewBagValues(String algorithmCode, String instructions)
        {
            ViewBag.Code = algorithmCode;
            ViewBag.Instructions = instructions;
        }
    }
}
