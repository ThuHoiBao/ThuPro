using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace StudentManagement
{
    public class DataBase
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MQDG3C6\SQLEXPRESS01;
                    Initial Catalog=TaiKhoanSV;Integrated Security=True;");

        public SqlConnection GetConnection
        {
            get
            {
                return con;
            }
        }
        public void OpenConnection()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public void CloseConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
