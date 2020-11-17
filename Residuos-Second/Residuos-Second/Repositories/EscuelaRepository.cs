using RESIDUOS.Repositories;
using Residuos_Second.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Residuos_Second.Repositories
{
    public class EscuelaRepository : Repository<Escuela>
    {
        public EscuelaRepository(residuosContext ctx) : base(ctx)
        {

        }

        public override IEnumerable<Escuela> GetAll()
        {
            return base.GetAll().OrderBy(x => x.Nombre);
        }

        
    }
}
