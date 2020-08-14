using Concesionario.Models;
using Concesionario.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Concesionario.Controllers
{
    public class ClientesController : Controller
    {
        // GET: Clientes
        [HttpGet]
        public ActionResult Index()
        {
            var c = ClientesRepository.ObtenerClientes();
            return View(c);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(new Clientes());
        }

        [HttpPost]
        public ActionResult Create([Bind(Include = "RazonSocial, Dni, Direccion, Localidad, Telefono, Celular, EMail, Observaciones")] Clientes cliente)
        {
            ClientesRepository.InsertarCliente(cliente);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var c = ClientesRepository.ObtenerCliente(id);
            return View(c);
        }

        [HttpPost]
        public ActionResult Editar([Bind(Include = "Id, RazonSocial, Dni, Direccion, Localidad, Telefono, Celular, EMail, Observaciones")] Clientes cliente)
        {
            ClientesRepository.ModificarCliente(cliente);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var c = ClientesRepository.ObtenerCliente(id);
            return View(c);
        }

        [HttpPost]
        public ActionResult Eliminar(int id)
        {
            ClientesRepository.EliminarCliente(id);
            return RedirectToAction("Index");
        }
    }
}