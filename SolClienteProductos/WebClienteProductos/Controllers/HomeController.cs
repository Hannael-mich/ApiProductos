using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using WebClienteProductos.Models;

namespace WebClienteProductos.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<ProductosExt> ls = new List<ProductosExt>();
            using (HttpClient clienteHttp = new HttpClient())
            {
                clienteHttp.BaseAddress = new Uri("http://localhost:64220/");
                var request = clienteHttp.GetAsync("api/Productos").Result;

                if (request.IsSuccessStatusCode)
                {
                    string resultado = request.Content.ReadAsStringAsync().Result;

                    ls = JsonConvert.DeserializeObject<List<ProductosExt>>(resultado);

                    return View(ls);
                }
                else
                {
                    TempData["error"] = "Error de comunicacion con el Api";
                    return View(new List<ProductosExt>());
                }
            }
        }
    }
}