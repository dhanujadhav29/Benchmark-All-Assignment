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
    public class DALOP
    {
        public SqlDataReader GetAllOp()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["conns"].ConnectionString;
            con.Open();

            SqlCommand cmd = new SqlCommand("ReadOp", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }



        public void InsertOp(Op s)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["conns"].ConnectionString;
            con.Open();

            SqlCommand cmd = new SqlCommand("InsertOP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Oid", s.Oid);
            cmd.Parameters.AddWithValue("Lid", s.Lid);
            cmd.Parameters.AddWithValue("Pid", s.Pid);
            

            cmd.ExecuteNonQuery();


        }

        public void UpdateOp(Op s)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["conns"].ConnectionString;
            con.Open();

            SqlCommand cmd = new SqlCommand("UpdateOp", con);
            cmd.CommandType = CommandType.StoredProcedure;
  
            cmd.Parameters.AddWithValue("Oid", s.Oid);
            cmd.Parameters.AddWithValue("Lid", s.Lid);
            cmd.Parameters.AddWithValue("Pid", s.Pid);

            cmd.ExecuteNonQuery();


        }
        public void DeleteOp(int Oid)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["conns"].ConnectionString;
            con.Open();

            SqlCommand cmd = new SqlCommand("DeleteOp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Oid", Oid);
            cmd.ExecuteNonQuery();

        }

    }
}