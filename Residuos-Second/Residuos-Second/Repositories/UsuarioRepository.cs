using Residuos_Second.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace RESIDUOS.Repositories
{
    public class UsuarioRepository : Repository<Usuario>
    {
        public UsuarioRepository(residuosContext ctx) : base(ctx)
        {
            
        }

       
    }
}
