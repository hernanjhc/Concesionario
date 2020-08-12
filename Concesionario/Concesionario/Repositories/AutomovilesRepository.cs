using Concesionario.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
        
        public static void InsertarAutomóviles(Automoviles auto)
        {
            using (var db = new ConcesionariosEntities())
            {
                var id = db.Automoviles.Any() ? db.Automoviles.Max(x => x.Id) + 1 : 1;
                auto.Id = id;
                db.Automoviles.Add(auto);
                db.SaveChanges();
            }
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

        public static void EditarAutomóviles(Automoviles auto)
        {
            using (var db = new ConcesionariosEntities())
            {
                db.Entry(auto).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}