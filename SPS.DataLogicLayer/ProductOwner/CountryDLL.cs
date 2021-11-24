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
        #region Country Master
        public int AddCountry(CountryModel countryModel)
        {
            int statusID = 0;
            try
            {
                if (countryModel != null)
                {
                    SqlParameter[] param = new SqlParameter[]
                    {
                        new SqlParameter("V_CountryName",countryModel.CountryName),
                        new SqlParameter("V_CountryDesc",countryModel.CountryDesc),
                        new SqlParameter("V_CreatedBy",countryModel.CreatedBy),
                        new SqlParameter("V_CountryStatus",countryModel.Status),
                    };
                    statusID = SqlHelper.ExcuteNonQuery(SPNames.SaveCountryMaster, param);
                }
                return statusID;

            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
        public int UpdateCountry(CountryModel countryModel)
        {
            int statusID = 0;
            try
            {
                if (countryModel != null)
                {
                    SqlParameter[] param = new SqlParameter[]
                    {
                        new SqlParameter("V_CountryID",countryModel.CountryId),
                        new SqlParameter("V_CountryName",countryModel.CountryName),
                        new SqlParameter("V_CountryDesc",countryModel.CountryDesc),
                        new SqlParameter("V_ModifiedBy",countryModel.ModifiedBy),
                        new SqlParameter("V_CountryStatus",countryModel.Status),
                    };
                    statusID = SqlHelper.ExcuteNonQuery(SPNames.UpdateCountryMaster, param);
                }
                return statusID;

            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        public List<CountryModel> GetCountryList()
        {
            List<CountryModel> CountryList = new List<CountryModel>();
            SqlDataReader dr = null;
            try
            {

                SqlParameter[] param = new SqlParameter[]
                {

                };
                dr = SqlHelper.ExcuteDataReader(SPNames.GetCountryList, param);
                if (dr != null)
                {
                    while (dr.HasRows && dr.Read())
                    {
                        var obj = new CountryModel()
                        {
                            CountryId = Convert.ToInt32(dr["CountryID"]),
                            CountryName = Convert.ToString(dr["CountryName"]),
                            CountryDesc = Convert.ToString(dr["CountryDesc"]),
                            Status = Convert.ToString(dr["CountryStatus"]),
                        };
                        CountryList.Add(obj);
                    }
                }
                return CountryList;

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (dr != null && !dr.IsClosed)
                {
                    dr.Close();
                }
            }
        }
        public CountryModel GetCountryByID(string CountryID)
        {
            SqlDataReader dr = null;
            CountryModel obj = new CountryModel();
            try
            {
                SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter("V_CountryID",CountryID)
                };
                dr = SqlHelper.ExcuteDataReader(SPNames.GetCountryByID, param);
                if (dr != null)
                {
                    while (dr.HasRows && dr.Read())
                    {
                        obj.CountryId = Convert.ToInt32(dr["CountryID"]);
                        obj.CountryName = Convert.ToString(dr["CountryName"]);
                        obj.CountryDesc = Convert.ToString(dr["CountryDesc"]);
                        obj.Status = Convert.ToString(dr["CountryStatus"]);
                    }
                }
                return obj;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (dr != null && !dr.IsClosed)
                {
                    dr.Close();
                }
            }
        }

        public int DeleteCountry(String CountryID)
        {
            int statusID = 0;
            try
            {
                if (CountryID != null)
                {
                    SqlParameter[] param = new SqlParameter[]
                    {
                        new SqlParameter("V_CountryID",CountryID),
                    };
                    statusID = SqlHelper.ExcuteNonQuery(SPNames.DeleteCountry, param);
                }
                return statusID;

            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
        #endregion

   
    }
}
