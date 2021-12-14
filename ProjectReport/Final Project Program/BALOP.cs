using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1
{
    public class BALOP
    {
        DALOP d = new DALOP();
        public List<Op> GetAllOp()
        {
            SqlDataReader reader = d.GetAllOp();
            List<Op> slist = new List<Op>();
            while (reader.Read())
            {
                Op obj = new Op();
                obj.Oid = Convert.ToInt32(reader["Oid"]);
                obj.Lid = Convert.ToInt32(reader["Lid"]);
                obj.Pid = Convert.ToInt32(reader["Pid"]);


                
                slist.Add(obj);
            }
            return slist;
        }
        public int InsertOp(int Oid,int Lid,int Pid)
        {
            try
            {
                Op s = new Op() { Oid=Oid,Lid = Lid, Pid=Pid };
                d.InsertOp(s);

                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine("error" + ex);
                return 0;
            }
        }

        public int UpdatetOp(int Oid, int Lid, int Pid)
        {
            try
            {
                Op s = new Op() { Oid = Oid, Lid = Lid, Pid = Pid };
                d.UpdateOp(s);

                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine("error" + ex);
                return 0;
            }
        }

        public int DeleteOp(int Oid)
        {
            try
            {
                d.DeleteOp(Oid);
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