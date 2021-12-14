using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using WebApplication1.Models;

namespace WebApplication1
{
    public class DAL1
    {
        public SqlDataReader ReadAllTask()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["conns"].ConnectionString;
            con.Open();

            SqlCommand cmd = new SqlCommand("ReadAllTask", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }
        public void InsertEmployee(Task s)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["conns"].ConnectionString;
            con.Open();

            SqlCommand cmd = new SqlCommand("InsertTask", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Tid", s.Tid);
            cmd.Parameters.AddWithValue("Tname", s.Tname);
            cmd.Parameters.AddWithValue("Tstatus", s.Tstatus);

            cmd.Parameters.AddWithValue("Tstart_Date", s.Tstart_Date);
            cmd.Parameters.AddWithValue("Tend_Date", s.Tstart_Date);
            cmd.Parameters.AddWithValue("Tdes", s.Tdes);


            cmd.ExecuteNonQuery();


        }
        public void UpdateEmployee(Task s)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["conns"].ConnectionString;
            con.Open();

            SqlCommand cmd = new SqlCommand("UpdateTask", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Tid", s.Tid);
            cmd.Parameters.AddWithValue("Tname", s.Tname);
            cmd.Parameters.AddWithValue("Tstatus", s.Tstatus);
            cmd.Parameters.AddWithValue("Tstart_Date", s.Tstart_Date);
          

            cmd.Parameters.AddWithValue("Tend_Date", s.Tstart_Date);
            cmd.Parameters.AddWithValue("Tdes", s.Tdes);


            cmd.ExecuteNonQuery();


        }
        public void DeleteTask(int Eid)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["conns"].ConnectionString;
            con.Open();

            SqlCommand cmd = new SqlCommand("DeleteTask", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Tid", Eid);
            cmd.ExecuteNonQuery();

        }

    }
}