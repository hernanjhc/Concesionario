using Concesionario.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Concesionario.Repositories
{
    public class VendedoresRepository
    {
        public static IEnumerable<Vendedores> ObtenerVendedores()
        {
            using (var db = new ConcesionariosEntities())
            {
                return db.Vendedores.ToList();
            }
        }

        public static Vendedores ObtenerVendedor(int id)
        {
            using (var db = new ConcesionariosEntities())
            {
                var vendedor = db.Vendedores.First(c => c.Id == id);
                return vendedor;
            }
        }

        public static void InsertarVendedor(Vendedores vendedor)
        {
            using (var db = new ConcesionariosEntities())
            {
                var id = db.Vendedores.Any() ? db.Vendedores.Max(c => c.Id) + 1 : 1;
                vendedor.Id = id;
                db.Vendedores.Add(vendedor);
                db.SaveChanges();
            }
        }

        public static void ModificarVendedor(Vendedores vendedor)
        {
            using (var db = new ConcesionariosEntities())
            {
                db.Entry(vendedor).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public static void EliminarVendedor(int id)
        {
            using (var db = new ConcesionariosEntities())
            {
                var c = db.Vendedores.Find(id);
                db.Vendedores.Remove(c);
                db.SaveChanges();
            }
        }
    }
}