using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SPS.CommonModel;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore;
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
        [HttpPost]
        public IActionResult Login(String UserName, string Password)
        {
            //Need DB 
            if (UserName.ToLower() == "po" && Password.ToLower() == "po")
            {
                UserInformationModel userInformationModelobj = new UserInformationModel();
                userInformationModelobj.UserId = "E47B1349-6CEB 4ED6-B4AE-36EDAE1B57F3";
                return RedirectToAction("Index", "Dashboard", new { area = "ProductOwner" });
            }
            else
            {
                return Json("Invalid Credentials");
            }
        }
    }
}
