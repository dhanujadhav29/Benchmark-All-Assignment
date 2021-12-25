using PlanProject.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace PlanProject.Views
{
    public class Dal1
    {
        public SqlDataReader GetAllLead()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["con1"].ConnectionString;
            con.Open();

            SqlCommand cmd = new SqlCommand("GetLead", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }



        public void InsertLead(Lead s)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["con1"].ConnectionString;
            con.Open();

            SqlCommand cmd = new SqlCommand("InsertLead", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Lid", s.Lid);
            cmd.Parameters.AddWithValue("Lname", s.Lname);
            cmd.Parameters.AddWithValue("Lphone", s.Lphone);
            cmd.Parameters.AddWithValue("Laddress", s.Laddress);
            cmd.Parameters.AddWithValue("Lemail", s.Lemail);
            cmd.Parameters.AddWithValue("Lgender", s.Lgender);

            cmd.ExecuteNonQuery();


        }

        public void UpdateLead(Lead s)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["con1"].ConnectionString;
            con.Open();

            SqlCommand cmd = new SqlCommand("UpdateLead", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Lid", s.Lid);
            cmd.Parameters.AddWithValue("Lname", s.Lname);
            cmd.Parameters.AddWithValue("Lphone", s.Lphone);
            cmd.Parameters.AddWithValue("Laddress", s.Laddress);
            cmd.Parameters.AddWithValue("Lemail", s.Lemail);
            cmd.Parameters.AddWithValue("Lgender", s.Lgender);

            cmd.ExecuteNonQuery();


        }
        public void DeleteLead(int Lid)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["con1"].ConnectionString;
            con.Open();

            SqlCommand cmd = new SqlCommand("DeleteLeadUsingLid", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Lid", Lid);
            cmd.ExecuteNonQuery();

        }
    }
}
