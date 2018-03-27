using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;

namespace BDKrishok.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Home()
        {
            _BDKrishokDB db = new _BDKrishokDB();
            ViewBag.Categories = db.Category.Where(c => c.SubCategory == null).ToList();
            
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