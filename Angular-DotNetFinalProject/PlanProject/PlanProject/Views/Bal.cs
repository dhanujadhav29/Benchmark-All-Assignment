using PlanProject.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PlanProject.Views
{
    public class Bal
    {
        Dal d = new Dal();
        public List<PlanData> GetAllPlan()
        {
            SqlDataReader reader = d.GetAllPlan();
            List<PlanData> slist = new List<PlanData>();
            while (reader.Read())
            {
                PlanData obj = new PlanData();
                obj.pid = Convert.ToInt32(reader["pid"]);
                obj.pname = reader["pname"].ToString();
                obj.price = Convert.ToInt32(reader["price"]);
                obj.pdescription = reader["pdescription"].ToString();
                obj.validity = reader["validity"].ToString();

                slist.Add(obj);
            }
            return slist;
        }
        public string Insert(int pid, string pname, int price, string pdescription, string validity)
        {
            try
            {
                PlanData s = new PlanData() { pid = pid, pname = pname, price = price, pdescription = pdescription, validity = validity };
                d.Insert(s);

                return "data inserted";
            }
            catch (Exception ex)
            {
                Console.WriteLine("error" + ex);
                return "data not inserted"+ex;
            }
        }

        public string Update(int pid, string pname, int price, string pdescription, string validity)
        {
            try
            {
                PlanData s = new PlanData() { pid = pid, pname = pname, price = price, pdescription = pdescription, validity = validity };
                d.Update(s);
                return "data updated successfully";
            }
            catch (Exception ex)
            {
                Console.WriteLine("error" + ex);
                return "data not updated successfully"+ex;
            }

        }


        public string Delete(int pid)
        {
            try
            {
                d.Delete(pid);
                return "Data deleted successfully!";
            }
            catch (Exception ex)
            {
                Console.WriteLine("error" + ex);
                return "Data not deleted ?";
            }
        }
    }
}