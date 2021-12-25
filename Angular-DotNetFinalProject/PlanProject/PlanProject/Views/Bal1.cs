using PlanProject.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PlanProject.Views
{
    public class Bal1
    { 
        Dal1 d = new Dal1();
        public List<Lead> GetAllLead()
        {
            SqlDataReader reader = d.GetAllLead();
            List<Lead> slist = new List<Lead>();
            while (reader.Read())
            {
                Lead obj = new Lead();
                obj.Lid = Convert.ToInt32(reader["Lid"]);
                obj.Lname = reader["Lname"].ToString();
                obj.Lphone = reader["Lphone"].ToString();
                obj.Laddress = reader["Laddress"].ToString();
                obj.Lemail = reader["Lemail"].ToString();
                obj.Lgender = reader["Lgender"].ToString();

                slist.Add(obj);
            }
            return slist;
        }
        public string InsertLead(int Lid, string Lname, string Lphone, string Laddress, string Lemail, string Lgender)
        {
            try
            {
                Lead s = new Lead() { Lid = Lid, Lname = Lname, Lphone = Lphone, Laddress = Laddress, Lemail = Lemail, Lgender = Lgender };
                d.InsertLead(s);

                return "data inserted!";
            }
            catch (Exception ex)
            {
                Console.WriteLine("error" + ex);
                return "data not inserted"+ex;
            }
        }

        public string UpdateLead(int Lid, string Lname, string Lphone, string Laddress, string Lemail, string Lgender)
        {
            try
            {
                Lead s = new Lead() { Lid = Lid, Lname = Lname, Lphone = Lphone, Laddress = Laddress, Lemail = Lemail, Lgender = Lgender };
                d.UpdateLead(s);
                return "Data updated successfully!";
            }
            catch (Exception ex)
            {
                Console.WriteLine("error" + ex);
                return "Data not updated successfully!"+ex;
            }

        }
        public string DeleteLead(int Lid)
        {
            try
            {
                d.DeleteLead(Lid);
                return "Data delete successfully!";
            }
            catch (Exception ex)
            {
                Console.WriteLine("error" + ex);
                return "Data not deleted";
            }
        }


    }
}


