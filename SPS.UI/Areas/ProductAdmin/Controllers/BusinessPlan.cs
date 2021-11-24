using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPS.UI.Areas.ProductOwner.Controllers
{
    public class BusinessPlan : Controller
    {
        public IActionResult PlanDetails()
        {
            return View();
        }
        public IActionResult DomainDetails()
        {
            return View();
        }
        public IActionResult HostingDetails()
        {
            return View();
        }
    }
}
