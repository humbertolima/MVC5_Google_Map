using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MapDemo.Models;

namespace MapDemo.Controllers
{
    public class HomeController : Controller
    {
        AllCountriesEntities db = new AllCountriesEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult Search(string postal_code)
        {
            place place = db.places.Where(x => x.postal_code.Equals(postal_code)).FirstOrDefault();
            return Json(place, JsonRequestBehavior.AllowGet);
        }
    }
    
}