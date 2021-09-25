using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPS.UI.Areas.ProductOwner.Controllers
{

    public class MasterData : Controller
    {
        public IActionResult Country()
        {
            return View();
        }
        public IActionResult State()
        {
            return View();
        }
    }
}
