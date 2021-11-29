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
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bsubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=.;Database=Assign1;trusted_connection=true");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Register values(@fname,@lname,@uname,@pwd,@cpwd,@addr,@dob)", con);
            cmd.Parameters.AddWithValue("fname", tfname.Text);
            cmd.Parameters.AddWithValue("lname", tlname.Text);
            cmd.Parameters.AddWithValue("uname", tuname.Text);
            cmd.Parameters.AddWithValue("pwd", tpwd.Text);
            cmd.Parameters.AddWithValue("cpwd", tcpwd.Text);
            cmd.Parameters.AddWithValue("addr",taddr.Text);
            cmd.Parameters.AddWithValue("dob", tdob.Text);

            cmd.ExecuteNonQuery();

            tfname.Text = "";
            tlname.Text = "";
            tpwd.Text = "";
            tcpwd.Text = "";
            tuname.Text = "";
            taddr.Text = "";
            tdob.Text = "";
            fname.Focus();

            con.Close();

        }
    }
}