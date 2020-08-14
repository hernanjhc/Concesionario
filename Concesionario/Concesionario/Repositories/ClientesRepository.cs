using Concesionario.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Concesionario.Repositories
{
    public static class ClientesRepository
    {
        public static IEnumerable<Clientes> ObtenerClientes()
        {
            using (var db = new ConcesionariosEntities())
            {
                return db.Clientes.ToList();
            }     
        }

        public static Clientes ObtenerCliente(int id)
        {
            using (var db = new ConcesionariosEntities())
            {
                var cliente = db.Clientes.First(c => c.Id == id);
                return cliente;
            }
        }

        public static void InsertarCliente(Clientes cliente)
        {
            using (var db = new ConcesionariosEntities())
            {
                var id = db.Clientes.Any() ? db.Clientes.Max(c => c.Id) + 1 : 1;
                cliente.Id = id;
                db.Clientes.Add(cliente);
                db.SaveChanges();
            }
        }

        public static void ModificarCliente(Clientes cliente)
        {
            using (var db = new ConcesionariosEntities())
            {
                db.Entry(cliente).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public static void EliminarCliente(int id)
        {
            using (var db = new ConcesionariosEntities())
            {
                var c = db.Clientes.Find(id);
                db.Clientes.Remove(c);
                db.SaveChanges();
            }
        }
    }
}