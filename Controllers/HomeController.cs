using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FizzbuzzMVC.Models;
using System.Text;

namespace FizzbuzzMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Solve()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Solve(string fizz, string buzz)
        {
            var fizzNum = Convert.ToInt32(fizz);
            var buzzNum = Convert.ToInt32(buzz);
            var output = new StringBuilder();
            for(var index = 1; index <= 100; index++)
            {
                if(index%buzzNum == 0 && index%fizzNum == 0)
                {
                    output.AppendLine("fizzbuzz");
                }
                else if (index%buzzNum == 0)
                {
                    output.AppendLine("buzz");
                }
                else if (index%fizzNum == 0)
                {
                    output.AppendLine("fizz");
                }
                else { 
                output.AppendLine(index.ToString());
                }
            }
            ViewData["OutPut"] = output.ToString();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
