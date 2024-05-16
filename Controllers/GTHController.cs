using MiniProjectCRUD.Models.ValidationClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiniProjectCRUD.Controllers
{
    public class GTHController : Controller
    {
        // GET: GTH
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(tblLoginModel lg)
        {
            return View();
        }
    }
}