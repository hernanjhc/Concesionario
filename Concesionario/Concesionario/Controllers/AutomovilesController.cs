using Concesionario.Models;
using Concesionario.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Concesionario.Controllers
{
    public class AutomovilesController : Controller
    {
        // GET: Automóviles
        public ActionResult Index()
        {
            cargarSelectLists();
            var a = AutomovilesRepository.ObtenerAutomoviles();
            return View(a);
        }

        private void cargarSelectLists()
        {
            ViewBag.TiposVehículo = TiposRepository.ObtenerTipos();
            ViewBag.Marcas = MarcasRepository.ObtenerMarcas();
            ViewBag.Modelos = ModelosRepository.ObtenerModelos();
            ViewBag.Estado = AutomovilesRepository.CargarOpcionesEstado();
            //ViewBag.Titulo = AutomovilesRepository.CargarOpcionesTitulo();
            //CargarOpcionesTitulo();
            ViewBag.Titulos = new List<SelectListItem>() {
                new SelectListItem{ Text = "(Seleccione)", Value = "", Selected = true},
                new SelectListItem { Text = "No", Value = "N" },
                new SelectListItem { Text = "Si", Value = "S" }
            };

            ViewBag.Cedula = AutomovilesRepository.CargarOpcionesCedula();
            ViewBag.F08 = AutomovilesRepository.CargarOpcionesF08();
            ViewBag.F12 = AutomovilesRepository.CargarOpcionesF12();
            ViewBag.Zeta = AutomovilesRepository.CargarOpcionesZeta();
            ViewBag.CompraVenta = AutomovilesRepository.CargarOpcionesCompraVenta();
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var a = AutomovilesRepository.ObtenerAutomovil(id);
            return View(a);
        }

        [HttpPost]
        public ActionResult Eliminar(int id)
        {
            AutomovilesRepository.EliminarAutomovil(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Marcas = MarcasRepository.CargarSelectListMarcas();
            cargarSelectListTipos();
            return View();
        }

        private void cargarSelectListTipos()
        {
            using (var db = new ConcesionariosEntities())
            {
                var tipos =
                    (from t in db.Tipos
                     select new SelectListItem
                     {
                         Text = t.Tipo,
                         Value = t.Id.ToString()
                     });
                ViewBag.Tipos = tipos.ToList();
            }

        }

        [HttpGet]
        public JsonResult CargarModelo(int idMarca)
        {
            List<ElementJsonIntKey> lst = new List<ElementJsonIntKey>();
            using (var db = new ConcesionariosEntities())
            {
                lst = (from m in db.Modelos
                       where m.IdMarca == idMarca
                       select new ElementJsonIntKey
                       {
                           Value = m.Id,
                           Text = m.Modelo
                       }
                       ).ToList();
            }
            return Json(lst, JsonRequestBehavior.AllowGet);
        }

        public class ElementJsonIntKey
        {
            public int Value { get; set; }
            public string Text { get; set; }
        }

    }
}