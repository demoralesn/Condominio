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
    public class CalculoController : Controller
    {
        // GET: Calculo
        public ActionResult Index()
        {
            IEnumerable<MonthState> owners = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:8080/api/");

                var responseTask = client.GetAsync("monthstate");

                responseTask.Wait();

                var result = responseTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<MonthState>>();

                    readTask.Wait();

                    owners = readTask.Result;
                }
                else
                {
                    owners = Enumerable.Empty<MonthState>();

                    ModelState.AddModelError(string.Empty, "Server error.");
                }
            }

            ViewBag.EmployeeList = owners;

            return View();
        }
    }
}