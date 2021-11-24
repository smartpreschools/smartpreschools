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
                UserInformationModel.UserId = "a04edc2b-46fb-4997-9896-a311c27fc95e";
                return RedirectToAction("Index", "Dashboard", new { area = "ProductAdmin" });
            }
            else
            {
                return Json("Invalid Credentials");
            }
        }
    }
}
