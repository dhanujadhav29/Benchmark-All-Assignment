using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace UrlRouting
{
    public partial class GridViewPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=.;Database=Assign1;trusted_connection=true");
            SqlCommand cmd = new SqlCommand("Select * From Article", con);
            SqlDataAdapter adapter= new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }

        protected string getTitle(object str) {
            return str.ToString().Replace(' ','-');
            //title contains space then replace space with (-)
        }
    }
}