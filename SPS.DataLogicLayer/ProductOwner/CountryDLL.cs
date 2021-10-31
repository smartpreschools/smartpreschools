using SPS.CommonModel.Model.ProductOwner;
using SPS.DataLogicLayer.Constants;
using SPS.IDataLogicLayer.ProductOwner;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;


namespace SPS.DataLogicLayer.ProductOwner
{
   public class CountryDLL : ICountryDLL
    {
        public int AddCountry(CountryModel countryModel)
        {
            int statusID = 0;
            try
            {
                if (countryModel != null)
                {
                    SqlParameter[] param = new SqlParameter[]
                    {
                        new SqlParameter("CountryName",countryModel.CountryName),
                        new SqlParameter("CountryDescrption",countryModel.CountryDescription),
                        new SqlParameter("CountryStatus",countryModel.Status),
                        new SqlParameter("CreatedBy",countryModel.CreatedBy),
                    };
                    statusID = SqlHelper.ExcuteNonQuery(SPNames.AddCountry, param);
                }
                return statusID;

            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
    }
}
