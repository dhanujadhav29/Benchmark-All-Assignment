using ProjectLead.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProjectLead
{
    public class BAL1
    {
        DAL1 d = new DAL1();
        public List<PlanData> GetAllPlan()
        {
            SqlDataReader reader = d.GetAllPlan();
            List<PlanData> slist = new List<PlanData>();
            while (reader.Read())
            {
                PlanData obj = new PlanData();
                obj.pid = Convert.ToInt32(reader["pid"]);
                obj.pname = reader["pname"].ToString();
                obj.price =Convert.ToInt32(reader["price"]);
                obj.pdescription = reader["pdescription"].ToString();
                obj.validity = reader["validity"].ToString();
                
                slist.Add(obj);
            }
            return slist;
        }
        public int Insert(int pid, string pname, int price, string pdescription, string validity)
        {
            try
            {
                PlanData s = new PlanData() { pid = pid, pname = pname, price=price,pdescription=pdescription, validity=validity};
                d.Insert(s);

                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine("error" + ex);
                return 0;
            }
        }

        public int Update(int pid, string pname, int price, string pdescription, string validity)
        {
            try
            {
                PlanData s = new PlanData() { pid = pid, pname = pname, price = price, pdescription = pdescription, validity = validity };
                d.Update(s);
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine("error" + ex);
                return 0;
            }

        }
        public int Delete(int pid)
        {
            try
            {
                d.Delete(pid);
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine("error" + ex);
                return 0;
            }
        }
    }
}