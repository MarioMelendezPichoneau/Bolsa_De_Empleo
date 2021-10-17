using BolsaEmpleo_Cliente.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BolsaEmpleo_Cliente.Controllers
{
    public class ofertaController : Controller
    {
        // GET: ofertaController
        public async Task<ActionResult> Index()
        {
            //https://localhost:44353/api/Ofertums
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync("https://localhost:44353/api/Ofertums");
            List<Oferta> ListaOfertas = JsonConvert.DeserializeObject<List<Oferta>>(json);

            return View(ListaOfertas);
        }

        // GET: ofertaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ofertaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ofertaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ofertaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ofertaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ofertaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ofertaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
