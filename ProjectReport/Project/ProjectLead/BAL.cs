using ProjectLead.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProjectLead
{
    public class BAL
    {
        DAL d = new DAL();
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
        public int InsertLead(int Lid, string Lname, string Lphone, string Laddress, string Lemail, string Lgender)
        {
            try
            {
               Lead s = new Lead() { Lid = Lid, Lname = Lname, Lphone = Lphone, Laddress = Laddress, Lemail = Lemail,Lgender=Lgender};
                d.InsertLead(s);
               
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine("error" + ex);
                return 0;
            }
        }

        public int UpdateLead(int Lid, string Lname, string Lphone, string Laddress, string Lemail, string Lgender)
        {
            try
            {
                Lead s = new Lead() { Lid = Lid, Lname = Lname, Lphone = Lphone, Laddress = Laddress, Lemail = Lemail, Lgender = Lgender };
                d.UpdateLead(s);
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine("error" + ex);
                return 0;
            }

        }
        public int DeleteLead(int Lid)
        {
            try
            {
                d.DeleteLead(Lid);
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine("error"+ex);
                return 0;
            }
        }

    }
}