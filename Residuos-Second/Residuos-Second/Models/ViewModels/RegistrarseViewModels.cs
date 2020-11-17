using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Residuos_Second.Models.ViewModels
{
    public class RegistrarseViewModels
    {
        public Usuario Usuario { get; set; }
        public IEnumerable<Escuela> Escuelas { get; set; }
    }
}
