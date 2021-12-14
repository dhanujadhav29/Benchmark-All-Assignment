using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class OpController : ApiController
    {
        BALOP b = new BALOP();
        [HttpGet]
        public List<Op> Read()
        {
            List<Op> list = b.GetAllOp();
            return list;
        }



        [HttpPost]
        public int Insert(Op s)
        {
            int res = b.InsertOp(s.Oid, s.Lid, s.Pid);
            return res;
        }

        [HttpPut]
        public int Update(Op s)
        {
            int res = b.InsertOp(s.Oid, s.Lid, s.Pid);
            return res;
        }

        [HttpDelete]
        public int DeleteOp(Op s)
        {
            int res = b.DeleteOp(s.Oid);
            return res;
        }
    }
}
