using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SPS.CommonModel.Model.ProductOwner;


namespace SPS.DataLogicLayer.ProductOwner
{
    class StateDLL
    {
        public int AddState(CountryModel countryModel)
        {
            string connectionInfo = "Server=.,Database=SmartPreSchool,User Name=Sa;Password=sa123,Intergrated Security=false";
            SqlConnection con = new SqlConnection(connectionInfo);
            con.Open();
            SqlCommand cmd = new SqlCommand("SPS_SP_SPAddCountry", con);

            cmd.ExecuteNonQuery();
            con.Close();
            return 1;
        }
    }
}
