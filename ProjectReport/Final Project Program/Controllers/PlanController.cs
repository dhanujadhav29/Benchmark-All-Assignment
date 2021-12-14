using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PlanController : ApiController
    {
        BALPLAN b = new BALPLAN();
        [HttpGet]
        public List<PlanData> Read()
        {
            List<PlanData> list = b.GetAllPlan();
            return list;
        }



        [HttpPost]
        public int Insert(PlanData s)
        {
            int res = b.Insert(s.Pid, s.Pname, s.price, s.pdescription, s.validity);
            return res;
        }

        [HttpPut]
        public int Update(PlanData s)
        {
            int res = b.Update(s.Pid, s.Pname, s.price, s.pdescription, s.validity);
            return res;
        }

        [HttpDelete]
        public int Delete(PlanData s)
        {
            int res = b.Delete(s.Pid);
            return res;
        }

    }
}
