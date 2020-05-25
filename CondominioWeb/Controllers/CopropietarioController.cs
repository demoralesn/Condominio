using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CondominioWeb.Models;
using CondominioWeb.DAL;
using System.Data;
using System.Net.Http;

namespace CondominioWeb.Controllers
{
    public class CopropietarioController : Controller
    {
        public ActionResult Index()
        {
            IEnumerable<Owner> owners = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:8080/api/");

                var responseTask = client.GetAsync("owner");

                responseTask.Wait();

                var result = responseTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<Owner>>();

                    readTask.Wait();

                    owners = readTask.Result;
                }
                else
                {
                    owners = Enumerable.Empty<Owner>();

                    ModelState.AddModelError(string.Empty, "Server error.");
                }
            }

            ViewBag.EmployeeList = owners;

            return View();
        }

        public ActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Crear(Owner own)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:8080/api/");

                var postTask = client.PostAsJsonAsync<Owner>("owner", own);
                
                postTask.Wait();

                var result = postTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    ViewBag.Tipo = 0;
                    ViewBag.Message = "Registro creado";
                }
                else
                {
                    ViewBag.Tipo = 1;
                    ViewBag.Message = "Error al crear";
                    ModelState.AddModelError(string.Empty, "Server error.");
                }
            }

            return View();
        }

        public ActionResult Editar(int id)
        {
            Owner own = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:8080/api/");

                var responseTask = client.GetAsync("owner/" + id.ToString());
                
                responseTask.Wait();

                var result = responseTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<Owner>();

                    readTask.Wait();

                    own = readTask.Result;
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Server error.");
                }
            }

            return View(own);
        }

        [HttpPost]
        public ActionResult Editar(Owner own)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:8080/api/");

                var putTask = client.PutAsJsonAsync<Owner>("owner", own);
                
                putTask.Wait();

                var result = putTask.Result;
                
                if (result.IsSuccessStatusCode)
                {
                    ViewBag.Tipo = 0;
                    ViewBag.Message = "Registro actualizado";
                }
                else
                {
                    ViewBag.Tipo = 1;
                    ViewBag.Message = "Error al actualizar";
                    ModelState.AddModelError(string.Empty, "Server error.");
                }
            }
            return View();
        }

        public ActionResult Eliminar(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:8080/api/");

                var deleteTask = client.DeleteAsync("owner/" + id.ToString());
                
                deleteTask.Wait();

                var result = deleteTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    ViewBag.Tipo = 0;
                    ViewBag.Message = "Registro eliminado";
                }
                else
                {
                    ViewBag.Tipo = 1;
                    ViewBag.Message = "Error al eliminar";
                    ModelState.AddModelError(string.Empty, "Server error.");
                }
            }
            return RedirectToAction("Index");
        }
    }
}