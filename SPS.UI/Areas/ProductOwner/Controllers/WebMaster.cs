using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPS.UI.Areas.ProductOwner.Controllers
{
    public class WebMaster : Controller
    {
        public IActionResult AddAdvertisement()
        {
            return View();
        }
        public IActionResult AdvertisementDetails()
        {
            return View();
        }
        public IActionResult AdvertisementDayTypeDetails()
        {
            return View();
        }
    }
}
