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
   public class StateBLL
    {
        private readonly IStateDLL stateDLLObj;
        public StateBLL()
        {
            stateDLLObj = new StateDLL();
        }


        public int AddState(StateModel stateModel)
        {
            try
            {
                return stateDLLObj.AddState(stateModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<StateModel> GetStateList()
        {
            try
            {
                return stateDLLObj.GetStateList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int UpdateState(StateModel stateModel)
        {
            try
            {
                return stateDLLObj.UpdateState(stateModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public StateModel GetStateByID(string stateId)
        {
            try
            {
                return stateDLLObj.GetStateByID(stateId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int DeleteState(String stateId)
        {
            try
            {
                return stateDLLObj.DeleteState(stateId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
