using MVC.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class AccessController : Controller
    {
        private SqlConnection con;
        //To Handle connection related activities
        private void connection()
        {
            string constr = ConfigurationManager.ConnectionStrings["getconn"].ToString();
            con = new SqlConnection(constr);

        }
        // GET: Employee/AddEmployee    
        public ActionResult PageReturn()
        {
            return View();
        }

        // POST: Employee/AddEmployee    
        [HttpPost]
        public ActionResult PageReturn(ModelFile modfile)
        {
            try
            {
                if (ModelState.IsValid)
                {
                   // modfile.InsertRegDetails(modfile);
                    //Creating function to insert details
                }

                return View();
            }
            catch
            {
                return View();
            }
        }
}
    }
