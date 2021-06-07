using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebProje.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Creat()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Creat(FormCollection form)
        {
            return View();
        }
    }
}