using Concesionario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Concesionario.Repositories
{
    public class AutomóvilesRepository
    {
        public static IEnumerable<Automoviles> ObtenerAutomoviles()
        {
            using (var db = new ConcesionariosEntities())
            {
                return db.Automoviles.ToList();
            }
        }
    }
}