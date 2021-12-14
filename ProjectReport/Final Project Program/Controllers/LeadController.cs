using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class LeadController : ApiController
    {
        BALLead b = new BALLead();
        [HttpGet]
        public List<Lead> Read()
        {
            List<Lead> list = b.GetAllLead();
            return list;
        }



        [HttpPost]
        public int Insert(Lead s)
        {
            int res = b.InsertLead(s.lid, s.Lname, s.Lphone, s.Laddress, s.Lemail, s.Lgender);
            return res;
        }

        [HttpPut]
        public int Update(Lead s)
        {
            int res = b.UpdateLead(s.lid, s.Lname, s.Lphone, s.Laddress, s.Lemail, s.Lgender);
            return res;
        }

        [HttpDelete]
        public int DeleteLead(Lead s)
        {
            int res = b.DeleteLead(s.lid);
            return res;
        }
    }
}
