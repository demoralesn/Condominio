using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CondominioWeb.ServiceReference1;

namespace CondominioWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Dashboard";
            return View();
        }

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

        public ActionResult Service()
        {
            ServiceClient sc = new ServiceClient();

            Propietario pt = new Propietario();

            pt = sc.BuscarPropietarioByID(1);

            ViewBag.Message = pt.Nombres;

            return View();
        }
    }
}