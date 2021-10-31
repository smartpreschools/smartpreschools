using SPS.CommonModel.Model.ProductOwner;
using SPS.DataLogicLayer.ProductOwner;
using SPS.IDataLogicLayer.ProductOwner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPS.BusinessLogicLayer.ProductOwner
{
   public class CountryBLL
    {
        private readonly  ICountryDLL countryDLLObj; 
        public CountryBLL()
        {
            countryDLLObj = new CountryDLL();
        }

        /// <summary>

        /// </summary>
        /// <param name="countryModel"></param>
        /// <returns></returns>
        public int AddCountry(CountryModel countryModel)
        {
            //Business Logic implentation
            return countryDLLObj.AddCountry(countryModel);
        }
    }
}
