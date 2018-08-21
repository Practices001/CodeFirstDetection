using facesesame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace facesesame.Controllers
{
    public class HomeController : Controller
    {
       
        public ActionResult Index()
        {
            if(User.IsInRole(RoleName.CanAccessAll))
                return View("Index");
            return View("NoAdminIndex");
        }

        [Authorize(Roles = RoleName.CanAccessAll)]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        
        public ActionResult Inicio()
        {
            if (User.IsInRole(RoleName.CanAccessAll))
                return View("InicioAdmin");
            return View("Inicio");
        }
    }
}