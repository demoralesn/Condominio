using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CondominioWeb.DAL;
using System.Data;
using CondominioWeb.Models;

namespace CondominioWeb.Controllers
{
    public class ResumenController : Controller
    {
        // GET: Resumen
        public ActionResult Index()
        {
            var cop = CargarGrilla();

            ViewBag.ResumenList = cop;

            return View();
        }

        private List<Resumen> CargarGrilla()
        {
            var resumenList = new List<Resumen>();
            using (var dt = BaseDatos.ExecuteDataTable("sp_c_resumen_estados"))
            {
                foreach (DataRow row in dt.Rows)
                {
                    var resumen = new Resumen()
                    {
                        Id = (int)row["Id"],
                        Anio = (int)row["Anio"],
                        Mes = (int)row["Mes"],
                        Ing_Rec = (int)row["Ing_Rec"],
                        Ing_Mul = (int)row["Ing_Mul"],
                        Egr_Nor = (int)row["Egr_Nor"],
                        Egr_Otr = (int)row["Egr_Otr"],
                        Ajust = (int)row["Ajust"],
                        Balan = (int)row["Balan"],
                    };
                    resumenList.Add(resumen);
                }
            }
            return resumenList;
        }
    }
}