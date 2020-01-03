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
    public class CalculoController : Controller
    {
        // GET: Calculo
        public ActionResult Index()
        {
            var pro = CargarTipos();

            IEnumerable<SelectListItem> Tipos = pro.Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Descripcion
            });

            ViewBag.Tipos = Tipos;

            return View();
        }

        private List<ListCalculo> CargarTipos()
        {
            var tiposList = new List<ListCalculo>();
            using (var dt = BaseDatos.ExecuteDataTable("sp_c_tipo_calculo"))
            {
                foreach (DataRow row in dt.Rows)
                {
                    var tipos = new ListCalculo()
                    {
                        Id = (int)row["id"],
                        Descripcion = row["descripcion"].ToString(),
                    };
                    tiposList.Add(tipos);
                }
            }
            return tiposList;
        }
    }
}