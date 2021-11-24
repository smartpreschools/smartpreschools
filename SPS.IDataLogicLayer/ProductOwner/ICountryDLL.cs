using SPS.CommonModel.Model.ProductOwner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPS.IDataLogicLayer.ProductOwner
{
    public interface ICountryDLL
    {
        #region Country Master
        int AddCountry(CountryModel countryModel);
        List<CountryModel> GetCountryList();
        int UpdateCountry(CountryModel countryModel);
        CountryModel GetCountryByID(string CountryID);
        int DeleteCountry(String CountryID);
        #endregion

       

    }
}
