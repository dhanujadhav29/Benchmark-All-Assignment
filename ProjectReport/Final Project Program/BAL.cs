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
    public class BAL
    {
        DAL d = new DAL();
        public List<Employee> ReadAllEmployees()
        {
            SqlDataReader reader = d.ReadAllEmployee();
            List<Employee> slist = new List<Employee>();
            while (reader.Read())
            {
                Employee obj = new Employee();
                obj.Eid = Convert.ToInt32(reader["Eid"]);
                obj.Ename = reader["Ename"].ToString();
                obj.Username = reader["Username"].ToString();
                obj.Epassword = reader["Epassword"].ToString();
                obj.Eaddress = reader["Eaddress"].ToString();
                obj.Email = reader["Email"].ToString();
                obj.Designation = reader["Designation"].ToString();
                obj.Phone = Convert.ToInt32(reader["Phone"]);
               obj.Aid = Convert.ToInt32((reader["Aid"].ToString()=="")?"0":reader["Aid"].ToString());
                slist.Add(obj);
            }
            return slist;
        }
        public Employee ReadEmployee(int Eid)
        {
            SqlDataReader reader = d.ReadEmployee(Eid);
            reader.Read();

            Employee obj = new Employee();
                obj.Eid = Convert.ToInt32(reader["Eid"]);
                obj.Ename = reader["Ename"].ToString();
                obj.Username = reader["Username"].ToString();
                obj.Epassword = reader["Epassword"].ToString();
                obj.Eaddress = reader["Eaddress"].ToString();
                obj.Email = reader["Email"].ToString();
                obj.Designation = reader["Designation"].ToString();
                obj.Phone = Convert.ToInt32(reader["Phone"]);
              obj.Aid = Convert.ToInt32((reader["Aid"].ToString() == "") ? "0" : reader["Aid"].ToString());

            return obj;
            
        }

        public int InsertEmployee(int eid, string ename, string username, string Pass, string addr, string email, string desig, int phone,int aid)
        {
            try
            {
                Employee s = new Employee() { Eid = eid, Ename = ename, Username = username, Epassword = Pass, Eaddress = addr, Email = email, Designation = desig, Phone = phone,Aid=aid };
                d.InsertEmployee(s);
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public int UpdateEmployee(int eid, string ename, string username, string Pass, string addr, string email, string desig, int phone, int aid)
        {
            try
            {
                Employee s = new Employee() { Eid = eid, Ename = ename, Username = username, Epassword = Pass, Eaddress = addr, Email = email, Designation = desig, Phone = phone, Aid = aid };
                d.UpdateEmployee(s);
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }

        }
        public int DeleteEmployee(int rno)
        {
            try
            {
                d.DeleteEmployee(rno);
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}