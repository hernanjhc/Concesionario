using Concesionario.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Concesionario.Controllers
{
    public class AutomóvilesController : Controller
    {
        // GET: Automóviles
        public ActionResult Index()
        {
            cargarSelectLists();
            var a = AutomóvilesRepository.ObtenerAutomoviles();
            return View(a);
        }

        private void cargarSelectLists()
        {
            var tipoVehículo = new List<SelectListItem>
            {
                new SelectListItem { Text = "Sedan", Value = "1" },
                new SelectListItem { Text = "5P", Value = "2" },
                new SelectListItem { Text = "PickUp", Value = "3" },
                new SelectListItem { Text = "Camión", Value = "4" },
                new SelectListItem { Text = "SUV", Value = "5" },
                new SelectListItem { Text = "Furgón", Value = "6" }
            };
            ViewBag.TipoVehículo = tipoVehículo;
            ViewBag.Marcas = MarcasRepository.ObtenerMarcas();
            ViewBag.Modelos = ModelosRepository.ObtenerModelos();
        }
    }
}