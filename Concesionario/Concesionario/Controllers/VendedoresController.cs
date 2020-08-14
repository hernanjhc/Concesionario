using Concesionario.Models;
using Concesionario.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Concesionario.Controllers
{
    public class VendedoresController : Controller
    {
        // GET: Vendedores
        public ActionResult Index()
        {
            var v = VendedoresRepository.ObtenerVendedores();
            return View(v);
        }

        // GET: Vendedores/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Vendedores/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Vendedores());
        }

        // POST: Vendedores/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "RazonSocial, Dni, Direccion, Localidad, Telefono, Celular, EMail, Observaciones")] Vendedores vendedor)
        {
            VendedoresRepository.InsertarVendedor(vendedor);
            return RedirectToAction("Index");
        }

        // GET: Vendedores/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var v = VendedoresRepository.ObtenerVendedor(id);
            return View(v);
        }

        // POST: Vendedores/Edit/5
        [HttpPost]
        public ActionResult Editar([Bind(Include = "Id, RazonSocial, Dni, Direccion, Localidad, Telefono, Celular, EMail, Observaciones")] Vendedores vendedor)
        {
            VendedoresRepository.ModificarVendedor(vendedor);
            return RedirectToAction("Index");
        }

        // GET: Vendedores/Delete/5
        public ActionResult Delete(int id)
        {
            var c = VendedoresRepository.ObtenerVendedor(id);
            return View(c);
        }

        // POST: Vendedores/Delete/5
        [HttpPost]
        public ActionResult Eliminar(int id)
        {
            VendedoresRepository.EliminarVendedor(id);
            return RedirectToAction("Index");
        }
    }
}
