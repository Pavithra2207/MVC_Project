using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {

        ModelFile model = new ModelFile();
        ModelFile model1 = new ModelFile();
        public ActionResult PageReturn()
        {
            model.departmentList.Add(new SelectListItem { Text = "Finance", Value = "1" });
            model.departmentList.Add(new SelectListItem { Text = "Manufacturing", Value = "2" });
            model.departmentList.Add(new SelectListItem { Text = "Transportation", Value = "3" });
            model.departmentList.Add(new SelectListItem { Text = "HR", Value = "4" });
            model.departmentList.Add(new SelectListItem { Text = "Others", Value = "5" });
            model1.year.Add(new SelectListItem { Text = "2015", Value = "1" });
            model1.year.Add(new SelectListItem { Text = "2016", Value = "2" });
            model1.year.Add(new SelectListItem { Text = "2017", Value = "3" });
            model1.year.Add(new SelectListItem { Text = "2018", Value = "4" });
            model1.year.Add(new SelectListItem { Text = "2019", Value = "5" });
            model1.year.Add(new SelectListItem { Text = "2020", Value = "6" });
            model1.year.Add(new SelectListItem { Text = "2021", Value = "7" });
            return View();
        }


        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}