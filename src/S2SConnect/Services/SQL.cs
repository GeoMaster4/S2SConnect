using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace S2SConnect.Services
{
    public class SQL
    {
        public const string connection = "Server=tcp:a4csgx5klf.database.windows.net,1433;Database=connectDBS;User ID=DBadmin@a4csgx5klf;Password=li0Ns8rAbb1t;Trusted_Connection=False;Encrypt=True;Connection Timeout=30;";
        public void LoginWrite(string username, string passwrd)
        {
            SqlConnection _sqlConn = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "INSERT INTO dbo.Students(username,password) VALUES (" + "\"" + username + "\"" +","+ "\"" + passwrd + "\"" + " );";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = _sqlConn;

            _sqlConn.Open();

            cmd.ExecuteNonQuery();

            _sqlConn.Close();
        }
    }
}
