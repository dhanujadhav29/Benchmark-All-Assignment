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
    public class DALPLAN
    {
        public SqlDataReader GetAllPlan()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["conns"].ConnectionString;
            con.Open();

            SqlCommand cmd = new SqlCommand("ReadPlan", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }

        public void Insert(PlanData s)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["conns"].ConnectionString;
            con.Open();

            SqlCommand cmd = new SqlCommand("InsertPlan", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Pid", s.Pid);
            cmd.Parameters.AddWithValue("Pname", s.Pname);
            cmd.Parameters.AddWithValue("price", s.price);
            cmd.Parameters.AddWithValue("pdescription", s.pdescription);
            cmd.Parameters.AddWithValue("validity", s.validity);

            cmd.ExecuteNonQuery();


        }

        public void Update(PlanData s)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["conns"].ConnectionString;
            con.Open();

            SqlCommand cmd = new SqlCommand("UpdatePlan1", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Pid", s.Pid);
            cmd.Parameters.AddWithValue("Pname", s.Pname);
            cmd.Parameters.AddWithValue("price", s.price);
            cmd.Parameters.AddWithValue("pdescription", s.pdescription);
            cmd.Parameters.AddWithValue("validity", s.validity);

            cmd.ExecuteNonQuery();


        }
        public void Delete(int Pid)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["conns"].ConnectionString;
            con.Open();

            SqlCommand cmd = new SqlCommand("DeletePlan", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Pid", Pid);
            cmd.ExecuteNonQuery();

        }
    }
}
