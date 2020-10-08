using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcArt.Controllers
{
    public class HiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Welcome(string name, int repeat = 1) {
            ViewData["Msg"] = "Hello :" + name;
            ViewData["HowMany"] = repeat;

            return View();
        }
    }
}
