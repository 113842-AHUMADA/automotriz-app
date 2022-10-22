using AutomotrizApp.datos.implementaciones;
using AutomotrizApp.datos.interfaces;
using AutomotrizApp.dominio;
using AutomotrizBack.negocio.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.negocio.implementaciones
{
    public class Aplicacion : IAplicacion
    {
        private IPedidoDao oDao;

        public Aplicacion()
        {
            oDao = new PedidoDao();
        }

        public List<Producto> ObtenerProductos()
        {
            return oDao.GetProductos();
        }

        public bool CrearPedido(Pedido oPedido)
        {
            return oDao.Create(oPedido);
        }
    }
}
