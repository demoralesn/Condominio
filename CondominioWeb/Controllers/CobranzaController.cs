using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CondominioWeb.Models;
using CondominioWeb.DAL;
using System.Data;

namespace CondominioWeb.Controllers
{
    public class CobranzaController : Controller
    {
        // GET: Cobranza
        public ActionResult Index()
        {
            var pro = CargarGrilla();

            IEnumerable<SelectListItem> Prop = pro.Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Numero
            });

            ViewBag.Prop = Prop;

            return View();
        }

        [HttpPost]
        public ActionResult Detalle(Cobranza cob)
        {
            return View(cob);
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