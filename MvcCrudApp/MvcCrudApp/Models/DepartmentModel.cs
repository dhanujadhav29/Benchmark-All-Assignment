using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcCrudApp.Models
{
    public class DepartmentModel
    {
        public int dno { set; get; }
        public string dname { set; get; }

        public string location { set; get; }
    }
}