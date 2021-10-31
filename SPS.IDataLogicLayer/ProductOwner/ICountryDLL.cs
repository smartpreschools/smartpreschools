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
        int AddCountry(CountryModel countryModel);
    }
}
