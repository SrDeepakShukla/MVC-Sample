using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class T_User_DetailController : Controller
    {
        // GET: T_User_Detail
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult SaveDetail(T_User_Detail details,int UserID)
        {
            T_User_DetailMethods tuser = new Models.T_User_DetailMethods();
            bool res= tuser.SaveRecord(details);
            return Json(res, JsonRequestBehavior.AllowGet);
        }
    }
}