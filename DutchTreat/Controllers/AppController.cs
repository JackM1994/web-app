using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DutchTreat.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            //throw new InvalidProgramException("Bad things happen");
            return View();
        }

        public IActionResult Contact()
        {
            ViewBag.Title = "Contact Us";

            return View();
        }
        public IActionResult About()
        {
            ViewBag.Title = "About Us";

            return View();
        }
    }
}
