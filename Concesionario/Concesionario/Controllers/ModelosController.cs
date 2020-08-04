using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Concesionario.Models;
using Concesionario.Repositories;

namespace Concesionario.Controllers
{
    public class ModelosController : Controller
    {
        // GET: Modelos
        public ActionResult Index()
        {
            var m = ModelosRepository.ObtenerModelos();
            ViewBag.Marcas = MarcasRepository.ObtenerMarcas();
            return View(m);
        }

        [HttpGet]
        public ActionResult Create()
        {
            cargarMarcas();
            return View();
        }

        private void cargarMarcas()
        {
            using (var db = new ConcesionariosEntities())
            {
                var marcas = from m in db.Marcas select new SelectListItem { Text = m.Marca, Value = m.Id.ToString() };
                ViewBag.Marcas = marcas.ToList();
            }
                
        }

        [HttpPost]
        public ActionResult Create([Bind(Include = "IdMarca, Modelo")] Modelos modelos)
        {
            ModelosRepository.InsertarModelo(modelos);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var m = ModelosRepository.ObtenerModelo(id);
            return View(m);
        }

        [HttpPost]
        public ActionResult Eliminar(int id)
        {
            ModelosRepository.EliminarModelo(id);
            return RedirectToAction("Index");
        }

    }
}