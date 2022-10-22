using AutomotrizApp.datos.interfaces;
using AutomotrizApp.dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizApp.datos.implementaciones
{
     class PedidoDao : IPedidoDao
    {
        public List<Producto> GetProductos()
        {
            List<Producto> lista = new List<Producto>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("SP_CONSULTAR_PRODUCTOS");

            foreach (DataRow fila in tabla.Rows)
            {
                Producto prod = new Producto();
                prod.Id_Producto = (int)fila["id_producto"];
                prod.Marca = fila["marca"].ToString();
                prod.Descripcion = fila["descripcion"].ToString();
                prod.Anio = (int)fila["anio"];
                prod.Stock = (bool)fila["stock"];
                prod.Precio_Vta = Convert.ToDouble(fila["precio_vta"]);
                
                lista.Add(prod);
            }
            return lista;
        }

        public bool Create(Pedido oPedido)
        {
            return HelperDao.ObtenerInstancia().CrearDetallePedido("SP_INSERTAR_PEDIDOS", "SP_INSERTAR_DETALLES", oPedido);
        }
    }
}
