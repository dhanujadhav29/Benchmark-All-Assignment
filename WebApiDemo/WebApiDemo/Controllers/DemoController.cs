using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiDemo.Controllers
{
    public class DemoController : ApiController
    {
        /*
        public string get() {

            return "Welcome To Web API Demo Application";
        }
        */

        public List<string> get() { 
        List<string> list = new List<string>();
            list.Add("Abcd");
            list.Add("xyz");
            return list;
        }
        
    }
}
