using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class TaskController : ApiController
    {
        BAL1 b = new BAL1();
        [HttpGet]
        public List<Task> Read()
        {
            List<Task> slist = b.ReadAllTask();
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
        public int Insert(Task s)
        {
            int res = b.InsertTask(s.Tid, s.Tname, s.Tstatus, s.Tstart_Date,s.Tend_Date,s.Tdes);
            return res;
        }

        [HttpPut]
        public int Update(Task s)
        {
            int res = b.UpdateTask(s.Tid, s.Tname, s.Tstatus, s.Tstart_Date, s.Tend_Date,s.Tdes);
            return res;
        }

        [HttpDelete]
        public int Delete(Task s)
        {
            int res = b.DeleteTask(s.Tid);
            return res;
        }
    }
}
