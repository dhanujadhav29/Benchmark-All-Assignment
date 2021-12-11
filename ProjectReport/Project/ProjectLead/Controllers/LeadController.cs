using ProjectLead.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjectLead.Controllers
{
    
    public class LeadController : ApiController
    {
        BAL b = new BAL();
        [HttpGet]
        public List<Lead> GetAllLead()
        {
            List<Lead> list = b.GetAllLead();
            return list;
        }



        [HttpPost]
        public int InsertLead(Lead s)
        {
            int res = b.InsertLead(s.Lid, s.Lname,s.Lphone, s.Laddress, s.Lemail,s.Lgender);
            return res;
        }

        [HttpPut]
        public int UpdateLead(Lead s)
        {
            int res = b.UpdateLead(s.Lid, s.Lname, s.Lphone, s.Laddress, s.Lemail, s.Lgender);
            return res;
        }

        [HttpDelete]
        public int DeleteLead(Lead s)
        {
            int res = b.DeleteLead(s.Lid);
            return res;
        }
    }
}

