using SPS.CommonModel.Model.ProductOwner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPS.IDataLogicLayer.ProductOwner
{
    public interface IStateDLL
    {
        #region State Master
        int AddState(StateModel stateModel);
        List<StateModel> GetStateList();
        int UpdateState(StateModel stateModel);
        StateModel GetStateByID(string stateId);
        int DeleteState(String stateId);
        #endregion
    }
}
