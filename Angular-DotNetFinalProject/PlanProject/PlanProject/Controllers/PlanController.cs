using PlanProject.Models;
using PlanProject.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PlanProject.Controllers
{
    public class PlanController : ApiController
    {
       
            Bal b = new Bal();
            [HttpGet]
            public List<PlanData> GetAllPlan()
            {
                List<PlanData> list = b.GetAllPlan();
                return list;
            }



            [HttpPost]
            public string Insert(PlanData s)
            {
                string res = b.Insert(s.pid, s.pname, s.price, s.pdescription, s.validity);
                return res;

            }

            [HttpPut]
            public string Update(PlanData s)
            {
               string  res=b.Update(s.pid, s.pname, s.price, s.pdescription, s.validity);
                return res ;
             }


        [HttpDelete]
            public string Delete(int id)
            {
                string res = b.Delete(id);
                return res;
            }
        }
    }

