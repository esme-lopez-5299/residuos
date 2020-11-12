using System;
using System.Collections.Generic;

#nullable disable

namespace RESIDUOS.Models
{
    public partial class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string ApellidoP { get; set; }
        public string ApellidoM { get; set; }
        public int? IdEscuela { get; set; }
        public string Usuario1 { get; set; }
        public string Contraseña { get; set; }

        public virtual Escuela IdEscuelaNavigation { get; set; }
    }
}
