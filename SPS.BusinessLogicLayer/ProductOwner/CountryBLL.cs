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

        
        public int AddCountry(CountryModel countryModel)
        {
            try
            {
                return countryDLLObj.AddCountry(countryModel);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public List<CountryModel> GetCountryList()
        {
            try
            {
                return countryDLLObj.GetCountryList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int UpdateCountry(CountryModel countryModel)
        {
            try
            {
                return countryDLLObj.UpdateCountry(countryModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public CountryModel GetCountryByID(string countryId)
        {
            try
            {
                return countryDLLObj.GetCountryByID(countryId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int DeleteCountry(String countryId)
        {
            try
            {
                return countryDLLObj.DeleteCountry(countryId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
