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
    public class Dal
    {
        public SqlDataReader GetAllPlan()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["con1"].ConnectionString;
            con.Open();

            SqlCommand cmd = new SqlCommand("GetPlanData", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }

        public void Insert(PlanData s)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["con1"].ConnectionString;
            con.Open();

            SqlCommand cmd = new SqlCommand("InsertPlanData", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("pid", s.pid);
            cmd.Parameters.AddWithValue("pname", s.pname);
            cmd.Parameters.AddWithValue("price", s.price);
            cmd.Parameters.AddWithValue("pdescription", s.pdescription);
            cmd.Parameters.AddWithValue("validity", s.validity);

            cmd.ExecuteNonQuery();


        }

        public void Update(PlanData s)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["con1"].ConnectionString;
            con.Open();

            SqlCommand cmd = new SqlCommand("UpdatePlanData", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("pid", s.pid);
            cmd.Parameters.AddWithValue("pname", s.pname);
            cmd.Parameters.AddWithValue("price", s.price);
            cmd.Parameters.AddWithValue("pdescription", s.pdescription);
            cmd.Parameters.AddWithValue("validity", s.validity);

            cmd.ExecuteNonQuery();


        }

        public void Delete(int pid)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["con1"].ConnectionString;
            con.Open();

            SqlCommand cmd = new SqlCommand("DeletePlanDataUsingPid", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("pid", pid);
            cmd.ExecuteNonQuery();

        }
    }
}
