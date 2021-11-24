using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPS.UI.Areas.ProductOwner.Controllers
{
    public class Business : Controller
    {
        public IActionResult BusinessHead()
        {
            return View();
        }
        public IActionResult BusinessInformation()
        {
            return View();
        }
    }
}
