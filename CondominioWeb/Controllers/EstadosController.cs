using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CondominioWeb.Models;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using iTextSharp.text.html.simpleparser;

namespace CondominioWeb.Controllers
{
    public class EstadosController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        // GET: Estados
        public ActionResult Pdf()
        {
            var est = new List<Estado>
            {
                new Estado { id=1,mes="octubre",anio=2019},
                new Estado { id=2,mes="septiembre",anio=2018}
            };
            return View(est);
        }

        [HttpPost]
        public ActionResult Test(FormCollection collection)
        {
            return View();
        }
    }
}