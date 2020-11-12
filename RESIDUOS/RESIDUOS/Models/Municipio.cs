using System;
using System.Collections.Generic;

#nullable disable

namespace RESIDUOS.Models
{
    public partial class Municipio
    {
        public Municipio()
        {
            Localidads = new HashSet<Localidad>();
        }

        public int IdMunicipio { get; set; }
        public string Nombre { get; set; }
        public sbyte? NumEscuelas { get; set; }

        public virtual ICollection<Localidad> Localidads { get; set; }
    }
}
