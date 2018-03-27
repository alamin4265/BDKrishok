using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;

namespace BDKrishok.Controllers
{
    public class MainCategoryController : Controller
    {
        private _BDKrishokDB db = new _BDKrishokDB();
        // GET: MainCategory
        public ActionResult Category(int? category)
        {
            if (category != null)
            {
                int cId = Convert.ToInt32(Request.QueryString["category"]);
                ViewBag.CategoryList = db.Category.Where(c => c.CategoryId == cId).ToList();
                ViewBag.Cat = db.Category.FirstOrDefault(c => c.Id == category);
                return View();
            }
            else
            {
                return RedirectToAction("Home", "Home");
            }

            
        }

        public ActionResult SubCategory(int? subcategory)
        {
            if (subcategory != null)
            {
                int cId = Convert.ToInt32(Request.QueryString["subcategory"]);
                ViewBag.CategoryList = db.Category.Where(c => c.CategoryId == cId).ToList();
                return View();
            }
            else
            {
                return RedirectToAction("Home", "Home");
            }


        }
    }
}