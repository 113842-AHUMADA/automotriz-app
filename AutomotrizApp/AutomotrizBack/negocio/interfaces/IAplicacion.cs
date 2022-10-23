using AutomotrizApp.dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.negocio.interfaces
{
    public interface IAplicacion
    {
        public List<Producto> ObtenerProductos();

        public bool CrearPedido(Pedido oPedido);

        public bool ActualizarPedido(Pedido oPedido);

        public bool BorrarPedido(int id);

        public List<Pedido> ObtenerPedidosPorFiltro(DateTime desde, DateTime hasta, string cliente);

        public Pedido ObtenerPedidoPorId(int id);

        DataTable ObtenerReporteProductos(DateTime desde, DateTime hasta);
    }
}
