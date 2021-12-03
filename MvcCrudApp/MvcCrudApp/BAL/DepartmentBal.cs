using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using MvcCrudApp.DAL;
using MvcCrudApp.Models;

namespace MvcCrudApp.BAL
{
    public class DepartmentBal
    {
        DepartmentDal d = new DepartmentDal();
        public List<DepartmentModel> GetDeptList() {
            SqlDataReader reader = d.GetDepartment();
            List<DepartmentModel> dlist= new List<DepartmentModel>();
            while (reader.Read()) {
                DepartmentModel dm = new DepartmentModel();
                dm.dno = Convert.ToInt32(reader["dno"].ToString());
                dm.dname = reader["dname"].ToString();
                dm.location = reader["location"].ToString();
                dlist.Add(dm);
            }
            return dlist;
        }

        public DepartmentModel GetDepartmentUsingDno(int dno)
        {
            SqlDataReader reader = d.GetDepartmentUsingDno(dno);
            
            DepartmentModel dm = null;

            while (reader.Read())
            {
                dm = new DepartmentModel();
                dm.dno = Convert.ToInt32(reader["dno"].ToString());
                dm.dname = reader["dname"].ToString();
                dm.location = reader["location"].ToString();
                
            }
            return dm;
        }

        public int InsertDepartment(DepartmentModel dm) 
        {
            int res = d.InsertDepartment(dm.dno,dm.dname,dm.location);
            return res;
        }

        public int UpdateDepartment(DepartmentModel dm)
        {
            int res = d.UpdateDepartment(dm.dno, dm.dname, dm.location);
            return res;
        }

        public int DeleteDepartment(int dno)
        {
            int res = d.DeleteDepartment(dno);
            return res;

        }


    }
}