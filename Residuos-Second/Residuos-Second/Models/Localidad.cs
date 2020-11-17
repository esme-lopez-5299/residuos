using System;
using System.Collections.Generic;

#nullable disable

namespace Residuos_Second.Models
{
    public partial class Localidad
    {
        public Localidad()
        {
            Escuelas = new HashSet<Escuela>();
        }

        public int IdLocalidad { get; set; }
        public string Nombre { get; set; }
        public sbyte? NumeroEscuelas { get; set; }
        public int? IdMunicipio { get; set; }

        public virtual Municipio IdMunicipioNavigation { get; set; }
        public virtual ICollection<Escuela> Escuelas { get; set; }
    }
}
