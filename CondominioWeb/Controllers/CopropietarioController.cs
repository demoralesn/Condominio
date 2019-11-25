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
    public class CopropietarioController : Controller
    {
        // GET: Copropietario
        public ActionResult Index()
        {
            var cop = CargarGrilla(0,0);

            ViewBag.EmployeeList = cop;

            return View();
        }

        public ActionResult Detalles()
        {
            return View();
        }
        
        public ActionResult Edicion()
        {
            return View();
        }

        public ActionResult Crear()
        {
            return View();
        }

        public JsonResult DeleteEmployee(int EmployeeId)
        {
            bool res = EliminarCop(EmployeeId);

            return Json(res, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Crear(Copropietario cop)
        {
            var res = Guardar(cop);

            if (res.Contains("Error")){
                ViewBag.Tipo = 1;
            }
            else
            {
                ViewBag.Tipo = 0;
            }

            ViewBag.Message = res;

            return View();
        }

        [HttpPost]
        public ActionResult Editar(Copropietario cop)
        {
            var res = Actualizar(cop);

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

        private List<Copropietario> CargarGrilla(int tipo, int id)
        {
            var copropietarioList = new List<Copropietario>();
            using (var dt = BaseDatos.ExecuteDataTable("sp_c_copropietario", tipo, id))
            {
                foreach (DataRow row in dt.Rows)
                {
                    var copropietario = new Copropietario()
                    {
                        Id = (int)row["id"],
                        Rut = row["rut"].ToString(),
                        Dv = row["dv"].ToString(),
                        Nombre = row["nombre"].ToString(),
                        Apellido = row["apellido"].ToString(),
                        Telefono = row["telefono"].ToString(),
                        _Genero = (Genero)Enum.Parse(typeof(Genero), row["genero"].ToString(), true),
                        Fec_Nac = row["fec_nac"].ToString(),
                        _Nacionalidad = (Nacionalidad)Enum.Parse(typeof(Nacionalidad), row["nacionalidad"].ToString(), true),
                        Email = row["email"].ToString(),
                    };
                    copropietarioList.Add(copropietario);
                }
            }
            return copropietarioList;
        }

        private bool EliminarCop(int CopID)
        {
            try
            {
                BaseDatos.ExecuteSql("sp_d_registro_copropietario", CopID);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private String Guardar(Copropietario cop)
        {
            try
            {
                BaseDatos.ExecuteSql("sp_i_registro_copropietario", cop.Rut, cop.Dv,cop.Nombre, cop.Apellido, cop.Telefono, cop._Genero, cop.Fec_Nac, cop._Nacionalidad, cop.Email);
                return "Registro guardado";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }

        private String Actualizar(Copropietario cop)
        {
            try
            {
                BaseDatos.ExecuteSql("sp_u_registro_copropietario", cop.Id, cop.Rut, cop.Dv, cop.Nombre, cop.Apellido, cop.Telefono, cop._Genero, cop.Fec_Nac, cop._Nacionalidad, cop.Email);
                return "Registro actualizado";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }

        public ActionResult Editar(int id)
        {
            var cop = CargarGrilla(1,id);

            var copro = cop.Where(c => c.Id == id).FirstOrDefault();

            return View(copro);
        }
    }
}