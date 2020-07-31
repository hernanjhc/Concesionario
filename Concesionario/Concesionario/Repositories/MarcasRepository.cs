using Concesionario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace Concesionario.Repositories
{
    public class MarcasRepository
    {

        public static IEnumerable<Marcas> ObtenerMarcas()
        {
            using (var db = new ConcesionariosEntities())
            {
                return db.Marcas.ToList();
            }
        }

        public static void InsertarMarca(string marca)
        {
            using (var db = new ConcesionariosEntities())
            {
                var m = new Marcas();
                var id = db.Marcas.Any() ? db.Marcas.Max(x => x.Id) + 1 : 1;
                m.Id = id;
                m.Marca = marca;
                db.Marcas.Add(m);
                db.SaveChanges();
            }
        }

        public static Marcas ObtenerMarca(int id)
        {
            using (var db = new ConcesionariosEntities())
            {
                return db.Marcas.Find(id);
            }
        }
    }
}