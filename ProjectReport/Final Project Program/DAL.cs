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
    public class DAL
    {
        public SqlDataReader ReadAllEmployee()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["conns"].ConnectionString;
            con.Open();

            SqlCommand cmd = new SqlCommand("ReadAllEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }

        public SqlDataReader ReadEmployee(int Eid)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["conns"].ConnectionString;
            con.Open();

            SqlCommand cmd = new SqlCommand("ReadEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Eid", Eid);

            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }

        public void InsertEmployee(Employee s)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["conns"].ConnectionString;
            con.Open();

            SqlCommand cmd = new SqlCommand("InsertEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Eid", s.Eid);
            cmd.Parameters.AddWithValue("Ename", s.Ename);
            cmd.Parameters.AddWithValue("Username", s.Username);
            cmd.Parameters.AddWithValue("Epassword", s.Epassword);
            cmd.Parameters.AddWithValue("Eaddress", s.Eaddress);
            cmd.Parameters.AddWithValue("Email", s.Email);
            cmd.Parameters.AddWithValue("Designation", s.Designation);
            cmd.Parameters.AddWithValue("Phone", s.Phone);
            cmd.Parameters.AddWithValue("Aid", s.Aid);

            cmd.ExecuteNonQuery();


        }
        public void UpdateEmployee(Employee s)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["conns"].ConnectionString;
            con.Open();

            SqlCommand cmd = new SqlCommand("UpdateEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Eid", s.Eid);
            cmd.Parameters.AddWithValue("Ename", s.Ename);
            cmd.Parameters.AddWithValue("Username", s.Username);
            cmd.Parameters.AddWithValue("Epassword", s.Epassword);
            cmd.Parameters.AddWithValue("Eaddress", s.Eaddress);
            cmd.Parameters.AddWithValue("Email", s.Email);
            cmd.Parameters.AddWithValue("Designation", s.Designation);
            cmd.Parameters.AddWithValue("Phone", s.Phone);
            cmd.Parameters.AddWithValue("Aid", s.Aid);

           

            cmd.ExecuteNonQuery();


        }
        public void DeleteEmployee(int Eid)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["conns"].ConnectionString;
            con.Open();

            SqlCommand cmd = new SqlCommand("DeleteEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Eid", Eid);
            cmd.ExecuteNonQuery();

        }
    }
}