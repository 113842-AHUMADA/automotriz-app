using AutomotrizApp.dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizApp.datos.interfaces
{
    interface IPedidoDao
    {
        List<Producto> GetProductos();

        bool Create(Pedido oPedido);

        bool Update(Pedido oPedido);

        bool Delete(int id);

        List<Pedido> GetPedidosPorFiltro(DateTime desde, DateTime hasta, string cliente);
        
        Pedido GetPedidoPorId(int id);

        DataTable GetReporteProductos(DateTime desde, DateTime hasta);

    }
}
