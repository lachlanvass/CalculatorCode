from os import chdir, mkdir, getcwd
from os.path import isfile, isdir
from sys import argv
calcName = argv[1]

controllerString = '''using System;
using Microsoft.AspNetCore.Mvc;
using CalculatorCode.Models;

namespace CalculatorCode.Controllers
{{
    public class {0}CalculatorController : Controller
    {{

        public IActionResult Index()
        {{
            SetViewBagValues();
            return View();
        }}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index({0}Calculator model)
        {{
            SetViewBagValues();
            if (!ModelState.IsValid)
            {{
                return View();
            }}

            String selectedValue = model.SelectedOperation;

            switch(selectedValue)
            {{
                case "Add"      : 
                                break;
                case "Subtract" : 
                                break;
                case "Multiply" : 
                                break;
                case "Divide": 
                            break;
            }}

            return View(model);
        }}

        public void SetViewBagValues()
        {{
            ViewBag.Code = AlgorithmCode;
            ViewBag.Instructions = "INSERT INSTRUCTIONS HERE";
        }}

        public const String AlgorithmCode =
@"INSERT CODE HERE";
    }}
}}'''.format(calcName)

viewString = '''@model CalculatorCode.Models.{0}Calculator

@{{
    ViewData["Title"] = "{0}";

    String algorithmCode = ViewBag.Code;
}}


<body>

    @using (Html.BeginForm())
    {{
        @Html.EditorFor(model => model.InputOne)
        <span> <br /> </span>
        @Html.EditorFor(model => model.InputTwo)
        <br />
        @Html.DropDownListFor(model => model.SelectedOperation,
                new SelectList(Enum.GetValues(typeof(Operations))), "Select Operation")
        <input type="submit" class="btn btn-success" />
        <span> <br /> </span>
        <h4>Result: </h4>
        @Html.DisplayFor(model => model.Result)

    }}
</body>

'''.format(calcName)

modelString = '''using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CalculatorCode.Models
{{
    public class {0}Calculator : Calculator
    {{
        [RegularExpression(@"^$", ErrorMessage = "Please enter a valid number")]
        new public int InputOne {{ get; set; }}

        [RegularExpression(@"^$", ErrorMessage = "Please enter a valid number")]
        new public int InputTwo {{ get; set; }}
        new public int Result {{ get; set; }}
        public SelectList Operations = new SelectList("Add", "Subtract", "Multiply", "Divide");

        public String SelectedOperation {{ get; set; }}
 
        public int CalculateAdditionResult()
        {{
            return InputOne + InputTwo;
        }}

        public int CalculateSubtractionResult()
        {{
            return InputOne - InputTwo;
        }}

        public int CalculateMultiplyResult()
        {{
            return InputOne * InputTwo;
        }}

        public int CalculateDivideResult()
        {{
            return InputOne / InputTwo;
        }}

    }}

}}'''.format(calcName)

# Enter visual studio project
print("Creating new MVC with name: {0}".format(calcName))
chdir(".\Controllers")
if (not isfile(calcName + "CalculatorController.cs")):
    print("Generating Controller in " + getcwd())
    controllerFile = open(calcName + "CalculatorController.cs", 'w')
    controllerFile.write(controllerString)
    controllerFile.close()
else:
    print("Controller already exists")

chdir("..")

if (not isfile(calcName + "Calculator.cs")):
    chdir(".\Models")
    print("Generating Model in " + getcwd())
    modelFile = open(calcName + "Calculator.cs", 'w')
    modelFile.write(modelString)
    modelFile.close()
else:
    print("Model file already exists")

chdir("..")

chdir(".\Views")
if (not isdir(calcName + "Calculator")):
    mkdir(calcName + "Calculator" )
    chdir(".\\{0}".format(calcName + "Calculator"))
    print("Generating View in " + getcwd())
    viewFile = open("Index.cshtml", 'w')
    viewFile.write(viewString)
    viewFile.close()
else:
    print("Views directory already exists")

print("Adding new calculator to AllCalculators.CalculatorList<String, String>")

def replace_line(file_name, line_num, text):
	# Courtsey of Stackoverflow
	# Peter C. 
	# At: https://stackoverflow.com/questions/4719438/editing-specific-line-in-text-file-in-python
	# Added newline to text to avoid having to increment line nume with each usage.
    lines = open(file_name, 'r').readlines()
    lines[line_num] = text
    out = open(file_name, 'w')
    out.writelines(lines)
    out.close()

print(getcwd())
chdir("..")
print(getcwd())
chdir(".\Views\Home")
print(getcwd())
calcListString = '''\tCalculatorList.Add("{0} Calculator", "{0}Calculator");\n'''.format(calcName)

lineToChange = 15
lineToChange = 18
#Navigate back to this file, and increase the lineToChange
lineToChange += 1
chdir("..")
chdir("..")
print("Incrementing lineToChange in newCalculator.py" + " " + str(lineToChange))
replace_line("newCalculator.py", 185, "lineToChange = " + str(lineToChange) + "\n")

print("COMPLETE")