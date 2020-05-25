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
    public class PropertyController : Controller
    {
        // GET: Property
        public ActionResult Index()
        {
            IEnumerable<Property> prop = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:8080/api/");

                var responseTask = client.GetAsync("property");

                responseTask.Wait();

                var result = responseTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<Property>>();

                    readTask.Wait();

                    prop = readTask.Result;
                }
                else
                {
                    prop = Enumerable.Empty<Property>();

                    ModelState.AddModelError(string.Empty, "Server error.");
                }
            }

            ViewBag.EmployeeList = prop;

            return View();
        }
    }
}