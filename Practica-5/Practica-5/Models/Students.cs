//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Practica_5.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Students
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public string Carrera { get; set; }
        public string Materias { get; set; }

        public  Estudiantes estudiantes { get; set; }
    }

    public enum Estudiantes
    {
        Ronald, Yarlin 
    }
}
