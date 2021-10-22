using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Municipality.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Average() => View();

        public IActionResult Chart() => View();
        
        public IActionResult Diagram() => View();
    }
}
