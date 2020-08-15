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
            ViewBag.Estados = CargarOpcionesEstado();
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
            //ViewBag.Tipos = CargarSelectListTipos();
            //ViewBag.Estados = CargarOpcionesEstado();
            return View(new Automoviles());
        }

        [HttpPost]
        public ActionResult Create([Bind(Include = "IdTipo, IdMarca, IdModelo, Dominio, Anio, MotorN, ChasisN, RegistradoEn, Precio, Observaciones, Color, Titulo, Cedula, F08, F12, Zeta, CompraVenta, Estado")] Automoviles autos)
        {
            AutomovilesRepository.InsertarAutomóviles(autos);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            ViewBag.Marcas = MarcasRepository.CargarSelectListMarcas();
            ViewBag.Tipos = CargarSelectListTipos();
            ViewBag.Estados = CargarOpcionesEstado();
            var a = AutomovilesRepository.ObtenerAutomovil(id);
            return View(a);
        }

        [HttpPost]
        public ActionResult Editar([Bind(Include = "Id, IdTipo, IdMarca, IdModelo, Dominio, Anio, MotorN, ChasisN, RegistradoEn, Precio, Observaciones, Color, Titulo, Cedula, F08, F12, Zeta, CompraVenta, Estado")] Automoviles autos)
        {
            AutomovilesRepository.EditarAutomóviles(autos);
            return RedirectToAction("Index");
        }

        private List<SelectListItem> CargarSelectListTipos()
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
                return tipos.ToList();
            }

        }

        public List<SelectListItem> CargarOpcionesEstado()
        {
            var estados = new List<SelectListItem>
            {
                new SelectListItem { Text = "Propio", Value = "0" },
                new SelectListItem { Text = "Consignación", Value = "1" },
                new SelectListItem { Text = "Vendido", Value = "2" }
            }.ToList();
            return estados;
        }

        public ActionResult CargarModelos(int id)
        {
            using (var db = new ConcesionariosEntities())
            {
                var result = (from m in db.Modelos
                              where m.IdMarca == id
                              select new SelectListItem
                              {
                                  Text = m.Modelo,
                                  Value = m.Id.ToString()
                              }).ToList();
                return PartialView("_cargarModelos", result);
            }
        }

        public class ElementJsonIntKey
        {
            public int Value { get; set; }
            public string Text { get; set; }
        }

    }
}