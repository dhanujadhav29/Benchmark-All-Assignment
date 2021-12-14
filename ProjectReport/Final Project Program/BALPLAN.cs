using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1
{
    public class BALPLAN
    {
        DALPLAN d = new DALPLAN();
        public List<PlanData> GetAllPlan()
        {
            SqlDataReader reader = d.GetAllPlan();
            List<PlanData> slist = new List<PlanData>();
            while (reader.Read())
            {
                PlanData obj = new PlanData();
                obj.Pid = Convert.ToInt32(reader["Pid"]);
                obj.Pname = reader["Pname"].ToString();
                obj.price = Convert.ToInt32(reader["price"]);
                obj.pdescription = reader["pdescription"].ToString();
                obj.validity = reader["validity"].ToString();

                slist.Add(obj);
            }
            return slist;
        }
        public int Insert(int Pid, string Pname, int price, string pdescription, string validity)
        {
            try
            {
                PlanData s = new PlanData() { Pid = Pid, Pname = Pname, price = price, pdescription = pdescription, validity = validity };
                d.Insert(s);

                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine("error" + ex);
                return 0;
            }
        }

        public int Update(int Pid, string Pname, int price, string pdescription, string validity)
        {
            try
            {
                PlanData s = new PlanData() { Pid = Pid, Pname = Pname, price = price, pdescription = pdescription, validity = validity };
                d.Update(s);
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine("error" + ex);
                return 0;
            }

        }
        public int Delete(int Pid)
        {
            try
            {
                d.Delete(Pid);
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