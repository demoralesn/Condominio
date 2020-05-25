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
    public class MonthStateController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Dashboard";

            IEnumerable<Period> periods = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:8080/api/");

                var responseTask = client.GetAsync("period");

                responseTask.Wait();

                var result = responseTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<Period>>();

                    readTask.Wait();

                    periods = readTask.Result;
                }
                else
                {
                    periods = Enumerable.Empty<Period>();

                    ModelState.AddModelError(string.Empty, "Server error.");
                }
            }

            ViewBag.Periods = periods;

            return View();
        }
    }
}