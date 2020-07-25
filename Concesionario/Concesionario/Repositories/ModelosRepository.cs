using Concesionario.Models;
using System;
using System.Collections.Generic;
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
    }
}