using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class DefaultController : Controller
    {
        [HttpGet]
        // GET: Default
        public ActionResult Index()
        {
            //MyModel mm = new Models.MyModel();
            //mm.Add()
            return View();
        }
        [HttpPost]
        public ActionResult Index(int a,int b)
        {
            MyModel mm = new Models.MyModel();
           int c= mm.Add(a, b);
            //ViewBag.Result = c;
            return View(c);
        }
        [HttpGet]
        // GET: Default
        public ActionResult Users()
        {
            MyModel mm = new Models.MyModel();
            ViewBag.Id = TempData["Id"];
            ViewBag.Nmae = TempData["Name"];
     return View(mm.GetUsers());
        }

        public ActionResult GetUserDetail(int id,string name)
        {
            //MyModel mm = new Models.MyModel();
            TempData["Id"] = id;
            TempData["Name"] = name;
            return RedirectToAction("Users");
        }
        public JsonResult GetJSONUSER(int Id, string Name)
        {
            //Annonymas method
            var Result = new {
                Id = Id,
                Name = Name,
            };
            return Json(Result, JsonRequestBehavior.AllowGet);
        }
    }
}