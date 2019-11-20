using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CondominioWeb.Models;

namespace CondominioWeb.Controllers
{
    public class CobranzaController : Controller
    {
        // GET: Cobranza
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Detalle(Cobranza cob)
        {
            return View(cob);
        }
    }
}