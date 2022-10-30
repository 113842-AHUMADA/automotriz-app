using AutomotrizApp.datos.implementaciones;
using AutomotrizApp.datos.interfaces;
using AutomotrizApp.dominio;
using AutomotrizBack.negocio.interfaces;
using System;
using System.Collections.Generic;
using System.Data;
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

        public bool ActualizarPedido(Pedido oPedido)
        {
            return oDao.Update(oPedido);
        }

        public bool BorrarPedido(int id)
        {
            return oDao.Delete(id);
        }

        public List<Pedido> ObtenerPedidosPorFiltro(DateTime desde, DateTime hasta, string cliente)
        {
            throw new NotImplementedException();
        }

        public Pedido ObtenerPedidoPorId(int id)
        {
            throw new NotImplementedException();
        }

        public DataTable ObtenerReporteProductos(DateTime desde, DateTime hasta)
        {
            throw new NotImplementedException();
        }

        public string Login(string usuario, string password)
        {
            return oDao.Login(usuario, password);  
        }
    }
}
