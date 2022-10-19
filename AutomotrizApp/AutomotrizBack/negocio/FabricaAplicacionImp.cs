using AutomotrizBack.negocio.implementaciones;
using AutomotrizBack.negocio.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.negocio
{
    internal class FabricaAplicacionImp : FabricaAplicacion
    {
        public override IAplicacion CrearApp()
        {
            return new Aplicacion();
        }
    }
}
