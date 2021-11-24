using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SPS.CommonModel.Model.ProductOwner;
using SPS.IDataLogicLayer.ProductOwner;
using SPS.DataLogicLayer.Constants;

namespace SPS.DataLogicLayer.ProductOwner
{
   public class StateDLL : IStateDLL
    {
        #region State Master
        public int AddState(StateModel stateModel)
        {
            int statusID = 0;
            try
            {
                if (stateModel != null)
                {
                    SqlParameter[] param = new SqlParameter[]
                    {
                        new SqlParameter("V_CountryId",stateModel.CountryId),
                        new SqlParameter("V_StateName",stateModel.StateName),
                         new SqlParameter("V_StateDesc",stateModel.StateDesc),
                        new SqlParameter("V_CreatedBy",stateModel.CreatedBy),
                        new SqlParameter("V_StateStatus",stateModel.Status),
                    };
                    statusID = SqlHelper.ExcuteNonQuery(SPNames.SaveStateMaster, param);
                }
                return statusID;

            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
        public int UpdateState(StateModel stateModel)
        {
            int statusID = 0;
            try
            {
                if (stateModel != null)
                {
                    SqlParameter[] param = new SqlParameter[]
                    {
                        new SqlParameter("V_stateId",stateModel.StateId),
                        new SqlParameter("V_CountryId",stateModel.CountryId),
                         new SqlParameter("V_stateName",stateModel.CountryName),
                         new SqlParameter("V_StateDesc",stateModel.StateDesc),
                        new SqlParameter("V_ModifiedBy",stateModel.ModifiedBy),
                        new SqlParameter("V_StateStatus",stateModel.Status),
                    };
                    statusID = SqlHelper.ExcuteNonQuery(SPNames.UpdateStateMaster, param);
                }
                return statusID;

            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        public List<StateModel> GetStateList()
        {
            List<StateModel> stateList = new List<StateModel>();
            SqlDataReader dr = null;
            try
            {

                SqlParameter[] param = new SqlParameter[]
                {

                };
                dr = SqlHelper.ExcuteDataReader(SPNames.GetStateList, param);
                if (dr != null)
                {
                    while (dr.HasRows && dr.Read())
                    {
                        var obj = new StateModel()
                        {
                            StateId = Convert.ToInt32(dr["StateId"]),
                            CountryName = Convert.ToString(dr["CountryName"]),
                            StateName = Convert.ToString(dr["StateName"]),
                            StateDesc = Convert.ToString(dr["StateDesc"]),
                            Status = Convert.ToString(dr["StateStatus"]),
                        };
                        stateList.Add(obj);
                    }
                }
                return stateList;

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
        public StateModel GetStateByID(string stateId)
        {
            SqlDataReader dr = null;
            StateModel obj = new StateModel();
            try
            {
                SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter("V_StateId",stateId)
                };
                dr = SqlHelper.ExcuteDataReader(SPNames.GetStateByID, param);
                if (dr != null)
                {
                    while (dr.HasRows && dr.Read())
                    {
                        obj.StateId = Convert.ToInt32(dr["StateId"]);
                        obj.CountryId = Convert.ToString(dr["CountryId"]);
                        obj.StateName = Convert.ToString(dr["StateName"]);
                        obj.StateDesc = Convert.ToString(dr["StateDesc"]);
                        obj.Status = Convert.ToString(dr["StateStatus"]);
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

        public int DeleteState(String stateId)
        {
            int statusID = 0;
            try
            {
                if (stateId != null)
                {
                    SqlParameter[] param = new SqlParameter[]
                    {
                        new SqlParameter("V_StateId",stateId),
                    };
                    statusID = SqlHelper.ExcuteNonQuery(SPNames.DeleteState, param);
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
