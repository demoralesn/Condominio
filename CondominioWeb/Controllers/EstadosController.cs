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
using CondominioWeb.DAL;
using System.Data;

namespace CondominioWeb.Controllers
{
    public class EstadosController : Controller
    {
        public ActionResult Index()
        {
            IEnumerable<SelectListItem> Years = Enumerable.Range(2008, DateTime.UtcNow.Year - 2007).Select(x => new SelectListItem
            {
                Value = x.ToString(),
                Text = x.ToString()
            });

            IEnumerable<SelectListItem> Months = Enumerable.Range(1, 12).Select(x => new SelectListItem
            {
                Value = x.ToString(),
                Text = DateTimeFormatInfo.CurrentInfo.GetMonthName(x)
            });

            var pro = CargarGrilla();

            IEnumerable<SelectListItem> Prop = pro.Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Numero
            });

            ViewBag.Years = Years;
            ViewBag.Months = Months;
            ViewBag.Prop = Prop;

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

        private List<ListPropiedad> CargarGrilla()
        {
            var propList = new List<ListPropiedad>();
            using (var dt = BaseDatos.ExecuteDataTable("sp_c_list_propiedad"))
            {
                foreach (DataRow row in dt.Rows)
                {
                    var prop = new ListPropiedad()
                    {
                        Id = (int)row["id"],
                        Numero = row["numero"].ToString(),
                    };
                    propList.Add(prop);
                }
            }
            return propList;
        }
    }
}