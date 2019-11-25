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
    public class PropiedadController : Controller
    {
        // GET: Propiedad
        public ActionResult Index()
        {
            var cop = CargarGrilla(0, 0);

            ViewBag.EmployeeList = cop;

            return View();
        }

        public ActionResult Crear()
        {
            return View();
        }

        private List<Propiedad> CargarGrilla(int tipo, int id)
        {
            var propiedadList = new List<Propiedad>();
            using (var dt = BaseDatos.ExecuteDataTable("sp_c_propiedad", tipo, id))
            {
                foreach (DataRow row in dt.Rows)
                {
                    var propiedad = new Propiedad()
                    {
                        Id = (int)row["id"],
                        Numero = row["numero"].ToString(),
                        _Tipo = (Tipo)Enum.Parse(typeof(Tipo), row["tipo"].ToString(), true),
                        Prorrateo = row["prorrateo"].ToString(),
                        Propietario = row["propietario"].ToString(),
                        _Estado_Prop = (EstadoPro)Enum.Parse(typeof(EstadoPro), row["estado_prop"].ToString(), true),
                    };
                    propiedadList.Add(propiedad);
                }
            }
            return propiedadList;
        }

        [HttpPost]
        public ActionResult Crear(Propiedad pro)
        {
            var res = Guardar(pro);

            if (res.Contains("Error"))
            {
                ViewBag.Tipo = 1;
            }
            else
            {
                ViewBag.Tipo = 0;
            }

            ViewBag.Message = res;

            return View();
        }

        private String Guardar(Propiedad pro)
        {
            try
            {
                BaseDatos.ExecuteSql("sp_i_registro_propiedad", pro.Numero, pro._Tipo, pro.Prorrateo, pro.Propietario, pro._Estado_Prop);
                return "Registro guardado";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }

        public JsonResult DeleteRealState(int EmployeeId)
        {
            bool res = EliminarProp(EmployeeId);

            return Json(res, JsonRequestBehavior.AllowGet);
        }

        private bool EliminarProp(int PropID)
        {
            try
            {
                BaseDatos.ExecuteSql("sp_d_registro_propiedad", PropID);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public ActionResult Editar(int id)
        {
            var cop = CargarGrilla(1, id);

            var copro = cop.Where(c => c.Id == id).FirstOrDefault();

            return View(copro);
        }

        [HttpPost]
        public ActionResult Editar(Propiedad pro)
        {
            var res = Actualizar(pro);

            if (res.Contains("Error"))
            {
                ViewBag.Tipo = 1;
            }
            else
            {
                ViewBag.Tipo = 0;
            }

            ViewBag.Message = res;

            return View();
        }

        private String Actualizar(Propiedad pro)
        {
            try
            {
                BaseDatos.ExecuteSql("sp_u_registro_propiedad", pro.Id, pro.Numero, pro._Tipo, pro.Prorrateo, pro.Propietario, pro._Estado_Prop);
                return "Registro actualizado";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
    }
}