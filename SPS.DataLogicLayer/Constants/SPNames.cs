using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPS.DataLogicLayer.Constants
{
    public class SPNames
    {
        #region Product Owner
        #region Country MAster
        public const string SaveCountryMaster = "SPS_ProcAddCountry";
        public const string GetCountryList = "SPS_ProcGetCountryList";
        public const string DeleteCountry = "SPS_ProcDeleteCountry";
        public const string GetCountryByID = "SPS_ProcGetCountryById";
        public const string UpdateCountryMaster = "SPS_ProcUpdateCountry";
        #endregion
        #region State Master
        public const string SaveStateMaster = "SPS_ProcAddState";
        public const string GetStateList = "SPS_ProcGetStateList";
        public const string DeleteState = "SPS_ProcDeleteState";
        public const string GetStateByID = "SPS_ProcGetStaeById";
        public const string UpdateStateMaster = "SPS_ProcUpdateState";
        #endregion
        #endregion
    }
}
