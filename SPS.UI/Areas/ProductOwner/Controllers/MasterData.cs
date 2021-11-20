using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SPS.CommonModel.Model.ProductOwner;
using SPS.BusinessLogicLayer.ProductOwner;
using System.Data.SqlClient;

namespace SPS.UI.Areas.ProductOwner.Controllers
{

    [Area("ProductOwner")]
    public class MasterData : Controller
    {
        private readonly CountryBLL countryBLLObj;
        public MasterData()
        {
            countryBLLObj = new CountryBLL();
        }

        //Constructor
        //deconstructor
        public IActionResult Country()
        {
            return View();
        }
        [HttpPost]  
       
        public IActionResult Country(CountryModel countryModel)
        {
            if (ModelState.IsValid)
            {
                countryModel.CreatedBy = Guid.NewGuid();
                countryModel.CountryDescription = "test";
                return Json(countryBLLObj.AddCountry(countryModel););
            }
            else
            {
                return Json(2);
            }
           
        }

        public IActionResult State()
        {
            return View();
        }
    }
}
