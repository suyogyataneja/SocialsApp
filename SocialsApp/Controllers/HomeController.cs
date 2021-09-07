using SocialsApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SocialsApp.Controllers
{
    public class HomeController : Controller
    {
        //url: "{controller}/{action}/{id}",

        SocialsDB db = new SocialsDB();

        // GET: Home
        public ActionResult Index()
        {

            var data = db.AppUsers.ToList();

            return View(data);
        }
    }
}