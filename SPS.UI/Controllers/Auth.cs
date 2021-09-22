using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPS.UI.Controllers
{
    public class Auth : Controller
    {
        private readonly ILogger<Auth> _logger;
        public Auth(ILogger<Auth> logger)
        {
            _logger = logger;
        }
        public IActionResult Login()
        {
            return View();
        }
    }
}
