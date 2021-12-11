using ProjectLead.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjectLead.Controllers
{
    public class PlanController : ApiController
    {
        BAL1 b = new BAL1();
        [HttpGet]
        public List<PlanData> GetAllPlan()
        {
            List<PlanData> list = b.GetAllPlan();
            return list;
        }



        [HttpPost]
        public int Insert(PlanData s)
        {
            int res = b.Insert(s.pid, s.pname, s.price, s.pdescription, s.validity);
            return res;
        }

        [HttpPut]
        public int Update(PlanData s)
        {
            int res = b.Update(s.pid, s.pname, s.price, s.pdescription, s.validity);
            return res;
        }

        [HttpDelete]
        public int Delete(PlanData s)
        {
            int res = b.Delete(s.pid);
            return res;
        }
    }
}
