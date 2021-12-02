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
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btnlogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=.;Database=Assign1;trusted_connection=true");
            SqlCommand cmd = new SqlCommand("select * from Login where uname=@uname and pwd=@pwd", con);
            cmd.Parameters.AddWithValue("@uname", tuname.Text);
            cmd.Parameters.AddWithValue("@pwd", tpwd.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();


            if (dt.Rows.Count > 0)
            {
                
                Response.Redirect("Welcome.aspx");
            }
            else
            {
                label.Text = "Invalid usernname or password";
                label.ForeColor = System.Drawing.Color.Red;

            }

            /*
            if (tuname.Text == "")
            {
                lbuname.Text = "Please Enter Username";
                lbuname.ForeColor = System.Drawing.Color.Red;
            }
            else if (tpwd.Text == "")
            {
                lbpass.Text = "Please Enter Password";
                lbpass.ForeColor = System.Drawing.Color.Red;
            }
            else {
                string uname = tuname.Text;
                string pwd=tpwd.Text;
                if (uname=="Admin"&& pwd=="pass@123")
                {
                    Response.Redirect("Welcome.aspx");

                }
                else {
                    lbuname.Text="";
                    lbpwd.Text="";
                    label.Text = "Invalid Username or Password";
                    label.ForeColor = System.Drawing.Color.Red;
                }

            */


        }
     }
 }
