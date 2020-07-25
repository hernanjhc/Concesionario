using Concesionario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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
    }
}