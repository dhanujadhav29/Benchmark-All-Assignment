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
    public partial class DetailsPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.RouteData.Values["Id"].ToString()!=null) { 

            string rid=Page.RouteData.Values["Id"].ToString();
            SqlConnection con = new SqlConnection("Server=.;Database=Assign1;trusted_connection=true");
            SqlCommand cmd = new SqlCommand("Select * From Article where id="+rid, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            string title = ds.Tables[0].Rows[0]["Title"].ToString();
            string desc = ds.Tables[0].Rows[0]["Desc"].ToString();
                label1.Text = title;
                label2.Text =desc;
            Page.DataBind();
            }

        }
    }
}