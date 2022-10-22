using AutomotrizApp.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.negocio.interfaces
{
    public interface IAplicacion
    {
        public List<Producto> ObtenerProductos();

        public bool CrearPedido(Pedido oPedido);
    }
}
