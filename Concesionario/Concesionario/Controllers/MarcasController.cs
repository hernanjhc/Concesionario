using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Concesionario.Models;
using Concesionario.Repositories;

namespace Concesionario.Controllers
{
    public class MarcasController : Controller
    {
        // GET: Marcas
        public ActionResult Index()
        {
            var m = MarcasRepository.ObtenerMarcas();
            return View(m);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(string marca)
        {
            MarcasRepository.InsertarMarca(marca);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var m = MarcasRepository.ObtenerMarca(Convert.ToInt32(id));
            return View(m);
        }

        [HttpPost]
        public ActionResult Eliminar(int id)
        {
            MarcasRepository.EliminarMarca(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit (int id)
        {
            var m = MarcasRepository.ObtenerMarca(id);
            return View(m);
        }

        [HttpPost]
        public ActionResult Editar(Marcas marca)
        {
            MarcasRepository.EditarMarca(marca);
            return RedirectToAction("Index");
        }
    }
}