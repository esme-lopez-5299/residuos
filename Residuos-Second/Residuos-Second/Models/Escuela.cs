using System;
using System.Collections.Generic;

#nullable disable

namespace Residuos_Second.Models
{
    public partial class Escuela
    {
        public Escuela()
        {
            Usuarios = new HashSet<Usuario>();
        }

        public int IdEscuela { get; set; }
        public string Clave { get; set; }
        public string Nombre { get; set; }
        public int NumeroAlumnos { get; set; }
        public sbyte? NumeroMaestros { get; set; }
        public string Turno { get; set; }
        public int? IdLocalidad { get; set; }

        public virtual Localidad IdLocalidadNavigation { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
