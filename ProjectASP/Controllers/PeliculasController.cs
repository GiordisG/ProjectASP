using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectASP.Models;

namespace ProjectASP.Controllers
{
    public class PeliculasController : Controller
    {
        // GET: Peliculas
        public ActionResult Index()
        {
            var data = new PeliculaModel().Consulta();
            return View(data);
        }

        // GET: Peliculas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Peliculas/Create
        [HttpPost]
        public ActionResult Create(PeliculaModel model)
        {
            new PeliculaModel().Insertar(model);
            return RedirectToAction("Index", "Peliculas");
        }

        // GET: Peliculas/Edit/5
        public ActionResult Edit(int id)
        {
            var data = new PeliculaModel().ConsultaId(id);
            return View(data);
        }

        // POST: Peliculas/Edit/5
        [HttpPost]
        public ActionResult Edit(PeliculaModel model)
        {
            new PeliculaModel().Editar(model);
            return RedirectToAction("Index", "Peliculas");
        }

        // GET: Peliculas/Delete/5
        public ActionResult Delete(int id)
        {
            new PeliculaModel().Eliminar(id);
            return RedirectToAction("Index", "Peliculas");
        }
    }
}
