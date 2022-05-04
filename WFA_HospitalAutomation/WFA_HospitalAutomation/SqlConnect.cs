using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WFA_HospitalAutomation
{
    class SqlConnect
    {
        public SqlConnection connection()
        {
            SqlConnection connect = new SqlConnection("Data Source=DESKTOP-SVP5E2K;Initial Catalog=HospitalAutomationProject;Integrated Security=True");
            connect.Open();
            return connect;
        }
    }
}
