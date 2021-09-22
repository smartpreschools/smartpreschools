using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPS.UI.Controllers
{
    public class SignUp : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
    }
}
