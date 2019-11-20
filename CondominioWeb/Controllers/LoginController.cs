using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CondominioWeb.Models;

namespace CondominioWeb.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Login lg)
        {
            if(!string.IsNullOrEmpty(lg.user) && !string.IsNullOrEmpty(lg.pass))
            {
                //Implementación temporal
                if (lg.user == "dmorales" && lg.pass == "12345")
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.Message = "Credenciales invalidas";
                    return View();
                }   
            }
            return View();
        }
    }
}