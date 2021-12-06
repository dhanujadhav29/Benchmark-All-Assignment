using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace ApiConsumer.Controllers
{
    public class ConsumerController : Controller
    {
        // GET: Consumer
        public ActionResult Index()
        {
          
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44335/api/Demo");
                var res = client.GetAsync("Demo");
                res.Wait();
                var result = res.Result;
                if (result.IsSuccessStatusCode)
                {
                    var data = result.Content.ReadAsAsync(typeof(List<string>));
                    data.Wait();
                    List<string> s = data.Result as List<string>;
                    List<SelectListItem> itemlist=new List<SelectListItem>();
                    foreach (var item in s) {
                        itemlist.Add(new SelectListItem() { Text=item,Value=item});
                    }

                    ViewData["res"]= itemlist;

                }
                else {
                    ViewData["res"] = "Error";
                }
           
            }
                return View();
        }
    }
}