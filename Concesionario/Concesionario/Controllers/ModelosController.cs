using Concesionario.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Concesionario.Controllers
{
    public class ModelosController : Controller
    {
        // GET: Modelos
        public ActionResult Index()
        {
            var modelos = ModelosRepository.ObtenerModelos();
            //var marcas = MarcasRepository.ObtenerMarcas();
            return View(modelos);
        }
    }
}