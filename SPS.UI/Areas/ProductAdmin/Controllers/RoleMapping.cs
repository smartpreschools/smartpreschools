using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPS.UI.Areas.ProductOwner.Controllers
{
    public class RoleMapping : Controller
    {
        public IActionResult RoleMaster()
        {
            return View();
        }
        public IActionResult ModuleMaster()
        {
            return View();
        }
        public IActionResult SubmoduleMaster()
        {
            return View();
        }
    }
}
