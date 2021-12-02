using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace LoginForm1
{
    public partial class Welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            int InsertDepartment(int tdno, string tdname, string tloc)
            {
                SqlConnection con = new SqlConnection("Server=.;Database=Assign1;trusted_connection=true");
                SqlCommand cmd = new SqlCommand("InsertDept", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dno", tdno);
                cmd.Parameters.AddWithValue("@dname", tdname);
                cmd.Parameters.AddWithValue("@location", tloc);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                return i;
                con.Close();


                int no = InsertDepartment(tdno, tdname, tloc);
                if (no > 0)
                {
                    Console.WriteLine("Data Inserted Succesfully");
                }




            }
        }
    }
}