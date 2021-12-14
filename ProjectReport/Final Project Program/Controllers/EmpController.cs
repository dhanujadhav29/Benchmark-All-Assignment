using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmpController : ApiController
    {
        BAL b = new BAL();
        [HttpGet]
        public List<Employee> Read()
        {
            List<Employee> slist = b.ReadAllEmployees();
            return slist;
        }

        /*[HttpGet]
        public Employee ReadEmployee(int rno)
        {
            Employee slist = b.ReadEmployee(rno);
            return slist;
        }
        */
        [HttpPost]
        public int Insert(Employee s)
        {
            int res = b.InsertEmployee(s.Eid, s.Ename, s.Username, s.Epassword, s.Eaddress, s.Email, s.Designation, s.Phone,s.Aid);
            return res;
        }

        [HttpPut]
        public int Update(Employee s)
        {
            int res = b.UpdateEmployee(s.Eid, s.Ename, s.Username, s.Epassword,s.Eaddress, s.Email, s.Designation, s.Phone,s.Aid);
            return res;
        }

        [HttpDelete]
        public int Delete(Employee s)
        {
            int res = b.DeleteEmployee(s.Eid);
            return res;
        }
    }
}
