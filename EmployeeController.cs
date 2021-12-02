using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using MvcDemoApplication.ViewModel;
using MvcDemoApplication.DAL;

namespace MvcDemoApplication.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            /*
             SqlConnection Con = new SqlConnection("Server=.;Database=Assign1;trusted_connection=true");
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select * From Emp",Con);
            SqlDataReader reader = cmd.ExecuteReader();

            //EmployeeVM ob = new EmployeeVM();

            List<EmployeeVM> ob=new List<EmployeeVM>();
            while (reader.Read()) {

            EmployeeVM ob1 = new EmployeeVM();
            ob1.eno = Convert.ToInt32(reader["eno"].ToString());
            ob1.ename = reader["ename"].ToString();
            ob1.salary = Convert.ToDecimal(reader["salary"].ToString());
            ob1.dno = Convert.ToInt32(reader["dno"].ToString());
            ob.Add(ob1);
            }
            */

            EmployeeListDal l = new EmployeeListDal();
            List<EmployeeVM> elist = l.GetEmpList();
            return View(elist);
        }
    }
}