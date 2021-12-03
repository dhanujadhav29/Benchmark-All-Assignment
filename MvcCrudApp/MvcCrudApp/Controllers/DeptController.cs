using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCrudApp.BAL;
using MvcCrudApp.Models;

namespace MvcCrudApp.Controllers
{
    public class DeptController : Controller
    {
        /*
        // GET: Dept
        DepartmentBal b=new DepartmentBal();
        public ActionResult Index()
        {
            List<DepartmentModel> dlist = b.GetDeptList();
            return View(dlist);
        }

        [HttpGet]
        public ActionResult InsertDept() {

            return View();
        }

        [HttpPost]
        public ActionResult InsertDept(FormCollection fc) {
            try
            {

                DepartmentModel m = new DepartmentModel();
                m.dno = Convert.ToInt32(fc["dno"].ToString());
                m.dname = fc["dname"].ToString();
                m.location = fc["location"].ToString();
                b.InsertDepartment(m);
                return RedirectToAction("Index");
            }
            catch (Exception e) { 
                TempData["error"]=e.Message;
                TempData["Backpage"] = "InsertDept";
                return RedirectToAction("ErrorPage");
            }

         }

        [HttpGet]
        public ActionResult UpdateDept(int dno)
        {
            DepartmentModel dm = b.GetDepartmentUsingDno(dno);
            return View(dm);
        }
        [HttpPost]
        public ActionResult UpdateDept(FormCollection fc)
        {
            try
            {

                DepartmentModel m = new DepartmentModel();
                m.dno = Convert.ToInt32(fc["dno"].ToString());
                m.dname = fc["dname"].ToString();
                m.location = fc["location"].ToString();
                b.UpdateDepartment(m);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                TempData["error"] = e.Message;
                TempData["Backpage"] = "Index";
                return RedirectToAction("ErrorPage");
            }

        }

        [HttpGet]
        public ActionResult DeleteDept(int dno)
        {
            try
            {

                b.DeleteDepartment(dno);
                return RedirectToAction("Index");
            }
            catch (Exception e) {
                TempData["error"] = e.Message;
                TempData["Backpage"] = "InsertDept";
                return RedirectToAction("ErrorPage");
            }
           
        }


        [HttpGet]
        public ActionResult DetailsDept(int dno)
        {
            DepartmentModel dm = b.GetDepartmentUsingDno(dno);
            return View(dm);

        }

            public ActionResult ErrorPage() {

            TempData.Keep("error");
            TempData.Keep("Backpage");
            return View();
        }

        */



        // GET: Dept
           DepartmentBal b = new DepartmentBal();
            public ActionResult Index()
            {
                List<DepartmentModel> dlist = b.GetDeptList();
                return View(dlist);
            }

        [HttpGet]
            public ActionResult InsertDept()
            {
                return View();
            }
      

        [HttpPost]
            public ActionResult InsertDept(FormCollection collection)
            {
                try
                {
                    DepartmentModel dm = new DepartmentModel();
                    dm.dno = Convert.ToInt32(collection["dno"].ToString());
                    dm.dname = collection["dname"].ToString();
                    dm.location = collection["location"].ToString();
                   
                    b.InsertDepartment(dm);
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    ViewData["error"] = ex.Message;
                    ViewData["backpage"] = "InsertDept";
                    return RedirectToAction("ErrorPage");
                }

            }



        [HttpGet]
            public ActionResult UpdateDept(int id)
            {
            DepartmentModel dm = b.GetDepartmentUsingDno(id);
                return View(dm);
            }

            [HttpPost]
            public ActionResult UpdateDept(FormCollection c)
            {
                try
                {
                    DepartmentModel dm = new DepartmentModel();
                    dm.dno = Convert.ToInt32(c["dno"].ToString());
                    dm.dname = c["dname"].ToString();
                    dm.location = c["location"].ToString();
                    b.UpdateDepartment(dm);
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    TempData["error"] = ex.Message;
                    TempData["backpage"] = "Index";
                    return RedirectToAction("ErrorPage");
                }

            }

            [HttpGet]
            public ActionResult DeleteDept(int id)
            {
                try
                {
                    b.DeleteDepartment(id);
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    TempData["error"] = ex.Message;
                    TempData["backpage"] = "Index";
                    return RedirectToAction("ErrorPage");
                }
            }

            [HttpGet]
            public ActionResult DetailsDept(int id)
            {
            DepartmentModel dm = b.GetDepartmentUsingDno(id);
                return View(dm);
            }

            [HttpGet]
            public ActionResult ErrorPage()
            {
                    TempData.Keep("error");
                    TempData.Keep("Backpage");
                    return View();
        }
         
        }
    }