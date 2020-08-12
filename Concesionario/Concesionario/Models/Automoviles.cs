//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Concesionario.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Automoviles
    {
        public int Id { get; set; }
        public string Dominio { get; set; }
        public Nullable<int> IdTipo { get; set; }
        public Nullable<int> IdMarca { get; set; }
        public Nullable<int> IdModelo { get; set; }
        public string Anio { get; set; }
        public string Color { get; set; }
        public string MotorN { get; set; }
        public string ChasisN { get; set; }
        public string RegistradoEn { get; set; }
        public Nullable<int> Estado { get; set; }
        public Nullable<decimal> Precio { get; set; }
        public string Observaciones { get; set; }
        public Nullable<bool> Titulo { get; set; }
        public Nullable<bool> Cedula { get; set; }
        public Nullable<bool> F08 { get; set; }
        public Nullable<bool> F12 { get; set; }
        public Nullable<bool> Zeta { get; set; }
        public Nullable<bool> CompraVenta { get; set; }
    
        public virtual Marcas Marcas { get; set; }
        public virtual Modelos Modelos { get; set; }
        public virtual Tipos Tipos { get; set; }
    }
}
