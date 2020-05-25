using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CondominioWeb.Models;
using System.Net.Http;

namespace CondominioWeb.Controllers
{
    public class IncomeController : Controller
    {
        // GET: Income
        public ActionResult Index()
        {
            IEnumerable<Income_Concept> income_desc = null;
            IEnumerable<Property> property_desc = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:8080/api/");

                var responseTask1 = client.GetAsync("property");
                var responseTask2 = client.GetAsync("income/concept");

                responseTask1.Wait();
                responseTask2.Wait();

                var result1 = responseTask1.Result;
                var result2 = responseTask2.Result;

                var readTask1 = result1.Content.ReadAsAsync<IList<Property>>();
                var readTask2 = result2.Content.ReadAsAsync<IList<Income_Concept>>();

                readTask1.Wait();
                readTask2.Wait();

                property_desc = readTask1.Result;
                income_desc = readTask2.Result;

            }

            ViewBag.Income_Desc = income_desc;
            ViewBag.Property_Desc = property_desc;

            return View();
        }

        [HttpPost]
        public ActionResult Crear(Income inc)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:8080/api/");

                var postTask = client.PostAsJsonAsync<Income>("income", inc);

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