using Concesionario.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Concesionario.Repositories
{
    public class ModelosRepository
    {
        public static IEnumerable<Modelos> ObtenerModelos()
        {
            using (var db = new ConcesionariosEntities())
            {
                return db.Modelos.ToList();
            }
        }

        public static void InsertarModelo(Modelos modelo)
        {
            using (var db = new ConcesionariosEntities())
            {
                var id = db.Modelos.Any() ? db.Modelos.Max(x => x.Id) + 1 : 1;
                modelo.Id = id;
                db.Modelos.Add(modelo);
                db.SaveChanges();
            }
        }

        public static Modelos ObtenerModelo(int id)
        {
            using (var db = new ConcesionariosEntities())
            {
                return db.Modelos.Find(id);
            }
        }

        public static void EliminarModelo(int id)
        {
            using (var db = new ConcesionariosEntities())
            {
                var m = db.Modelos.Find(id);
                db.Modelos.Remove(m);
                db.SaveChanges();
            }
        }

        public static void EditarModelo(Modelos modelo)
        {
            using (var db = new ConcesionariosEntities())
            {
                db.Entry(modelo).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}