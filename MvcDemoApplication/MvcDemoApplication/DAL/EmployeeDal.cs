using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MvcDemoApplication.DAL
{
    public class EmployeeDal
    {
        public SqlDataReader GetEmpData() {
            SqlConnection con = new SqlConnection("Server=.;Database=Assign1;trusted_connection=true");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * From Emp", con);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }
    }
}