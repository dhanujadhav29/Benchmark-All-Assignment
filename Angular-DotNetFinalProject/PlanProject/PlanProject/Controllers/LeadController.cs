using PlanProject.Models;
using PlanProject.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PlanProject.Controllers
{
    public class LeadController : ApiController
    {
        /*
        Bal1 b = new Bal1();
        [HttpGet]
        public List<Lead> GetAllLead()
        {
            List<Lead> list = b.GetAllLead();
            return list;
        }



        [HttpPost]
        public string InsertLead(Lead s)
        {
            string res = b.InsertLead(s.Lid, s.Lname, s.Lphone, s.Laddress, s.Lemail, s.Lgender);
            return res;
        }

        [HttpPut]
        public string UpdateLead(Lead s)
        {
            string res = b.UpdateLead(s.Lid, s.Lname, s.Lphone, s.Laddress, s.Lemail, s.Lgender);
            return res;
        }

        [HttpDelete]
        public string DeleteLead(int Lid)
        {
            string res = b.DeleteLead(Lid);
            return res;
        }

        */


            public HttpResponseMessage Get()
            {
                string query = @"
                    select Lid,Lname,Laddress,Lphone,Lemail,Lgender from
                    dbo.Lead
                    ";
                DataTable table = new DataTable("Lead");
                using (var con = new SqlConnection(ConfigurationManager.
                    ConnectionStrings["con1"].ConnectionString))
                using (var cmd = new SqlCommand(query, con))
                using (var da = new SqlDataAdapter(cmd))
                {
                    cmd.CommandType = CommandType.Text;
                    da.Fill(table);
                }

                return Request.CreateResponse(HttpStatusCode.OK, table);


            }

            public string Post(Lead l)
            {
                try
                {
                string query = @"insert into dbo.Lead values(
                          '" + l.Lname + @"',
                           '" + l.Laddress + @"',
                            '" + l.Lphone + @"',
                             '" + l.Lemail + @"',
                              '" + l.Lgender + @"'

                            
                    )";
                DataTable table = new DataTable("Lead");
                    using (var con = new SqlConnection(ConfigurationManager.
                        ConnectionStrings["con1"].ConnectionString))
                    using (var cmd = new SqlCommand(query, con))
                    using (var da = new SqlDataAdapter(cmd))
                    {
                        cmd.CommandType = CommandType.Text;
                        da.Fill(table);
                    }

                    return "Added Successfully!!";



                }
                catch (Exception) { return "Failed to Add!!"; }


            }

            public string Put(Lead l)
            {
                try
                {
                   string query = @"update dbo.Lead set
                               Lname='" + l.Lname + @"',
                               Laddress='" + l.Laddress + @"',
                               Lphone='" + l.Lphone + @"',
                               Lemail='" + l.Lemail + @"',
                               Lgender='" + l.Lgender + @"'
                               where Lid=" + l.Lid + @"
                           ";

                DataTable table = new DataTable("Lead");
                    using (var con = new SqlConnection(ConfigurationManager.
                        ConnectionStrings["con1"].ConnectionString))
                    using (var cmd = new SqlCommand(query, con))
                    using (var da = new SqlDataAdapter(cmd))
                    {
                        cmd.CommandType = CommandType.Text;
                        da.Fill(table);
                    }

                    return "Updated Successfully!!";


                }
                catch (Exception) { return "Failed to Update!!"; }

            }

            public string Delete(int id)
            {
                try
                {
                    string query = @"delete from dbo.Lead where Lid=" + id + @"
                 ";
                    DataTable table = new DataTable("Lead");
                    using (var con = new SqlConnection(ConfigurationManager.
                        ConnectionStrings["con1"].ConnectionString))
                    using (var cmd = new SqlCommand(query, con))
                    using (var da = new SqlDataAdapter(cmd))
                    {
                        cmd.CommandType = CommandType.Text;
                        da.Fill(table);
                    }

                    return "Deleted Successfully!!";


                }
                catch (Exception) { return "Failed to Delete!!"; }

            }




        }
    }

