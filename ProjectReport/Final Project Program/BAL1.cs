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
    public class BAL1
    {
        DAL1 d = new DAL1();
        public List<Task> ReadAllTask()
        {
            SqlDataReader reader = d.ReadAllTask();
            List<Task> slist = new List<Task>();
            while (reader.Read())
            {
                Task obj = new Task();
                obj.Tid = Convert.ToInt32(reader["Tid"]);
                obj.Tname = reader["tname"].ToString();
                obj.Tstatus = reader["Tstatus"].ToString();
                obj.Tstart_Date = reader["Tstart_Date"].ToString();
                obj.Tend_Date = reader["Tend_Date"].ToString();
                obj.Tdes = reader["Tdes"].ToString();
                slist.Add(obj);
            }
            return slist;
        }
        public int InsertTask(int tid, string tname,string st,string sd,string ed,string td)
        {
            try
            {
                Task s = new Task() { Tid=tid,Tname=tname,Tstatus=st,Tstart_Date=sd,Tend_Date=ed,Tdes=td };
                d.InsertEmployee(s);
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }

        }
        public int UpdateTask(int tid, string tname, string st, string sd, string ed, string td)
        {
            try
            {
                Task s = new Task() { Tid = tid, Tname = tname, Tstatus = st, Tstart_Date = st, Tend_Date = ed ,Tdes=td};
                d.UpdateEmployee(s);
              
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }

        }
        public int DeleteTask(int rno)
        {
            try
            {
                d.DeleteTask(rno);
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }


    }

}