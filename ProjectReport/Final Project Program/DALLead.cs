using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using WebApplication1.Models;

   namespace WebApplication1
   {
    public class DALLead
    {
        public SqlDataReader GetAllLead()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["conns"].ConnectionString;
            con.Open();

            SqlCommand cmd = new SqlCommand("GetLead", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }



        public void InsertLead(Lead s)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["conns"].ConnectionString;
            con.Open();

            SqlCommand cmd = new SqlCommand("InsertLead", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("lid", s.lid);
            cmd.Parameters.AddWithValue("Lname", s.Lname);
            cmd.Parameters.AddWithValue("LPhone", s.Lphone);
            cmd.Parameters.AddWithValue("Laddress", s.Laddress);
            cmd.Parameters.AddWithValue("Lemail", s.Lemail);
            cmd.Parameters.AddWithValue("Lgender", s.Lgender);

            cmd.ExecuteNonQuery();


        }

        public void UpdateLead(Lead s)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["conns"].ConnectionString;
            con.Open();

            SqlCommand cmd = new SqlCommand("UpdateLead", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("lid", s.lid);
            cmd.Parameters.AddWithValue("Lname", s.Lname);
            cmd.Parameters.AddWithValue("LPhone", s.Lphone);
            cmd.Parameters.AddWithValue("Laddress", s.Laddress);
            cmd.Parameters.AddWithValue("Lemail", s.Lemail);
            cmd.Parameters.AddWithValue("Lgender", s.Lgender);

            cmd.ExecuteNonQuery();


        }
        public void DeleteLead(int lid)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["conns"].ConnectionString;
            con.Open();

            SqlCommand cmd = new SqlCommand("DeleteLead", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("lid", lid);
            cmd.ExecuteNonQuery();

        }
    }
}