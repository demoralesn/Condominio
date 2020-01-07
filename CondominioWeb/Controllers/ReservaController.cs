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
    public class ReservaController : Controller
    {
        // GET: Reserva
        public ActionResult Crear()
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

        [HttpPost]
        public ActionResult Crear(Reserva cop)
        {
            var res = Guardar(cop);

            if (res.Contains("Error"))
            {
                ViewBag.Tipo = 1;
            }
            else
            {
                ViewBag.Tipo = 0;
            }

            ViewBag.Message = res;

            var pro = CargarGrilla();

            IEnumerable<SelectListItem> Prop = pro.Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Numero
            });

            ViewBag.Prop = Prop;

            return View();
        }
        private String Guardar(Reserva cop)
        {
            try
            {
                BaseDatos.ExecuteSql("sp_i_registro_reserva", cop.Propiedad, cop.dtDateFrom);
                return "Registro guardado";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
    }
}