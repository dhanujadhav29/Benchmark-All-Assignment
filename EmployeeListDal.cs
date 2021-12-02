using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using MvcDemoApplication.DAL;
using MvcDemoApplication.ViewModel;

namespace MvcDemoApplication.DAL
{
    public class EmployeeListDal
    {
        public List<EmployeeVM> GetEmpList()
        {
            EmployeeDal d = new EmployeeDal();
            SqlDataReader reader = d.GetEmpData();

            List<EmployeeVM> ob = new List<EmployeeVM>();
            while (reader.Read())
            {

                EmployeeVM ob1 = new EmployeeVM();
                ob1.eno = Convert.ToInt32(reader["eno"].ToString());
                ob1.ename = reader["ename"].ToString();
                ob1.salary = Convert.ToDecimal(reader["salary"].ToString());
                ob1.dno = Convert.ToInt32(reader["dno"].ToString());
                ob.Add(ob1);

            }
            return ob;
        }
    }
}