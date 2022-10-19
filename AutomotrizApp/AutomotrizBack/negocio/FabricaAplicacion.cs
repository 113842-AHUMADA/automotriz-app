using AutomotrizBack.negocio.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.negocio
{
     abstract class FabricaAplicacion
    {
        public abstract IAplicacion CrearApp();
    }
}
