using Concesionario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace Concesionario.Repositories
{
    public class TiposRepository
    {
        public static IEnumerable<Tipos> ObtenerTipos()
        {
            using (var db = new ConcesionariosEntities())
            {
                return db.Tipos.ToList();
            }
        }
    }
}