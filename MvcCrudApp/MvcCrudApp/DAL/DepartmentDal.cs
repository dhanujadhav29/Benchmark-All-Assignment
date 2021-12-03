using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MvcCrudApp.DAL
{
    public class DepartmentDal
    {
        public SqlDataReader GetDepartment()
        {
            SqlDataReader reader = null;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=Assign1;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("GetDept", con);
                cmd.CommandType = CommandType.StoredProcedure;

                reader = cmd.ExecuteReader();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error" + ex.Message);
                throw;

            }
            return reader;
        }

        public SqlDataReader GetDepartmentUsingDno(int dno)
        {
            SqlDataReader reader = null;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=Assign1;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("GetDeptUsingDno", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter("dno", dno);
                cmd.Parameters.Add(param);

                reader = cmd.ExecuteReader();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error " + ex.Message);
                throw;
            }
            return reader;
        }

        public int InsertDepartment(int dno, string dname, string location)
        {
            int no = 0;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=Assign1;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("InsertDept", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("dno", dno);
                cmd.Parameters.AddWithValue("dname", dname);
                cmd.Parameters.AddWithValue("location", location);
                
                no = cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception " + ex.Message);
                throw;
            }
            return no;
        }

        public int UpdateDepartment(int dno, string dname, string location)
        {
            int no = 0;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=Assign1;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("UpdateDeptData", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("dno", dno);
                cmd.Parameters.AddWithValue("dname", dname);
                cmd.Parameters.AddWithValue("location", location);
                
                no = cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error " + ex.Message);
                throw;
            }
            return no;
        }

        public int DeleteDepartment(int dno)
        {
            int no = 0;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=Assign1;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("DeleteDeptUsingDno", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("dno", dno);
                no = cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error " + ex.Message);
                throw;
            }
            return no;
        }

    }
}