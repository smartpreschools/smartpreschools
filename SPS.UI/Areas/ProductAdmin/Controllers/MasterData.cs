using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SPS.CommonModel.Model.ProductOwner;
using SPS.BusinessLogicLayer.ProductOwner;
using System.Data.SqlClient;
using SPS.CommonModel;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using System.Text.Json;

namespace SPS.UI.Areas.ProductAdmin.Controllers
{
    
    [Area("ProductAdmn")]
    public class MasterData : Controller
    {
        private readonly CountryBLL countryBLLObj;
        private readonly StateBLL stateBLLObj;
        public MasterData()
        {
            countryBLLObj = new CountryBLL();
            stateBLLObj = new StateBLL();
        }

        //Constructor

        #region Country Master
        public IActionResult Country()
        {
            return View();
        }
        [HttpPost]  
        public IActionResult AddCountry(CountryModel countryModel)
        {
            try
            {
                if (ModelState.IsValid)
                 {
                    Guid s = Guid.NewGuid();
                    countryModel.CreatedBy = new Guid( UserInformationModel.UserId);
                    return Json(countryBLLObj.AddCountry(countryModel));
                }
                else
                {
                    return Json(2);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        [HttpPost]
        public IActionResult UpdateCountry(CountryModel countryModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    countryModel.ModifiedBy = new Guid( UserInformationModel.UserId);
                    return Json(countryBLLObj.UpdateCountry(countryModel));
                }
                else
                {
                    return Json(2);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpGet]
        public JsonResult GetCountryList()
        { 
            try
            {
                return  Json(countryBLLObj.GetCountryList()) ;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpPost]
        public IActionResult DeleteCountry(string countryId)
        {
            try
            {
                return Json(countryBLLObj.DeleteCountry(countryId));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpPost]
        public IActionResult GetCountryByID(string countryId)
        {
            try
            {
                return Json(countryBLLObj.GetCountryByID(countryId));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
        #region Sate Master
        public IActionResult State()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddState(StateModel stateModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    stateModel.CreatedBy = new Guid(UserInformationModel.UserId);
                    return Json(stateBLLObj.AddState(stateModel));
                }
                else
                {
                    return Json(2);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpPost]
        public IActionResult UpdateState(StateModel stateModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    stateModel.ModifiedBy = new Guid(UserInformationModel.UserId);
                    return Json(stateBLLObj.UpdateState(stateModel));
                }
                else
                {
                    return Json(2);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpGet]
        public JsonResult GetStateList()
        {
            try
            {
                return Json(stateBLLObj.GetStateList());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpPost]
        public IActionResult DeleteState(string stateId)
        {
            try
            {
                return Json(stateBLLObj.DeleteState(stateId));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpPost]
        public IActionResult GetStateByID(string stateId)
        {
            try
            {
                return Json(stateBLLObj.GetStateByID(stateId));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

    }
}
