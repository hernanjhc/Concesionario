using Concesionario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Concesionario.Repositories
{
    public class AutomovilesRepository
    {
        public static IEnumerable<Automoviles> ObtenerAutomoviles()
        {
            using (var db = new ConcesionariosEntities())
            {
                return db.Automoviles.ToList();
            }
        }

        public static Automoviles ObtenerAutomovil(int id)
        {
            using (var db = new ConcesionariosEntities())
            {
                return db.Automoviles.Find(id);
            }
        }

        public static void EliminarAutomovil(int id)
        {
            using (var db = new ConcesionariosEntities())
            {
                var a = db.Automoviles.Find(id);
                db.Automoviles.Remove(a);
                db.SaveChanges();
            }
        }

        public static List<SelectListItem> CargarOpcionesCompraVenta()
        {
            var opciones = new List<SelectListItem>
            {
                new SelectListItem { Text = "No", Value = "0" },
                new SelectListItem { Text = "Si", Value = "1" }
            };
            return opciones;

        }

        public static List<SelectListItem> CargarOpcionesZeta()
        {
            var opciones = new List<SelectListItem>
            {
                new SelectListItem { Text = "No", Value = "0" },
                new SelectListItem { Text = "Si", Value = "1" }
            };
            return opciones;

        }

        public static List<SelectListItem> CargarOpcionesF12()
        {
            var opciones = new List<SelectListItem>
            {
                new SelectListItem { Text = "No", Value = "0" },
                new SelectListItem { Text = "Si", Value = "1" }
            };
            return opciones;

        }

        public static List<SelectListItem> CargarOpcionesF08()
        {
            var opciones = new List<SelectListItem>
            {
                new SelectListItem { Text = "No", Value = "0" },
                new SelectListItem { Text = "Si", Value = "1" }
            };
            return opciones;

        }

        public static List<SelectListItem> CargarOpcionesCedula()
        {
            var opciones = new List<SelectListItem>
            {
                new SelectListItem { Text = "No", Value = "0" },
                new SelectListItem { Text = "Si", Value = "1" }
            };
            return opciones;

        }

        public static IEnumerable<SelectListItem> CargarOpcionesTitulo()
        {
            var opciones = new List<SelectListItem>
            {
                new SelectListItem { Text = "No", Value = "N" },
                new SelectListItem { Text = "Si", Value = "S" }
            };
            return opciones;
        }

        public static List<SelectListItem> CargarOpcionesEstado()
        {
            var estados = new List<SelectListItem>
            {
                new SelectListItem { Text = "Propio", Value = "0" },
                new SelectListItem { Text = "Consignación", Value = "1" },
                new SelectListItem { Text = "Vendido", Value = "2" }
            }.ToList();
            return estados;
        }
    }
}