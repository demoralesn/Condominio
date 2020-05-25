using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CondominioWeb.Models;
using System.Net.Http;

namespace CondominioWeb.Controllers
{
    public class PagosController : Controller
    {
        // GET: Pagos
        public ActionResult Index()
        {
            ViewBag.Title = "Pagos";

            IEnumerable<Expense_Concept> expense_conc = null;
            IEnumerable<Expense_Entity> expense_ent = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:8080/api/");

                var responseTask1 = client.GetAsync("expense/concept");
                var responseTask2 = client.GetAsync("expense/entity");

                responseTask1.Wait();
                responseTask2.Wait();

                var result1 = responseTask1.Result;
                var result2 = responseTask2.Result;

                var readTask1 = result1.Content.ReadAsAsync<IList<Expense_Concept>>();
                var readTask2 = result2.Content.ReadAsAsync<IList<Expense_Entity>>();

                readTask1.Wait();
                readTask2.Wait();

                expense_conc = readTask1.Result;
                expense_ent = readTask2.Result;
                
            }

            ViewBag.Expense_Concept = expense_conc;
            ViewBag.Expense_Entity = expense_ent;

            return View();
        }

        [HttpPost]
        public ActionResult Crear(Expense exp)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:8080/api/");

                var postTask = client.PostAsJsonAsync<Expense>("expense", exp);

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
    }
}