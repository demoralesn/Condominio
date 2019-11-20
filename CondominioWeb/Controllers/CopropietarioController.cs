using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CondominioWeb.Models;

namespace CondominioWeb.Controllers
{
    public class CopropietarioController : Controller
    {
        // GET: Copropietario
        public ActionResult Index()
        {
            var Coprop = new List<Copropietario>
            {
                new Copropietario { Nombre="Daniel",Apellido="Morales",Fec_Nac="1987-10-14",Nacionalidad="Chileno",
                    Email ="demoralesn@gmail.com",Telefono="62345017"},
            };

            return View(Coprop);
        }
        
        public ActionResult Crear()
        {
            return View();
        }

        public ActionResult Editar()
        {
            return View();
        }

        public ActionResult Eliminar()
        {
            return View();
        }
    }
}