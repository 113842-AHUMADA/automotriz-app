using AutomotrizApp.datos.implementaciones;
using AutomotrizApp.datos.interfaces;
using AutomotrizApp.dominio;
using AutomotrizBack.datos;
using AutomotrizBack.datos.implementaciones;
using AutomotrizBack.datos.interfaces;
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
        private IDocumentoDao documentoDao;
        private IProductoDao productoDao;
        private ILoginDao loginDao;

        public Aplicacion()
        {
            documentoDao = new DocumentoDao();
            productoDao = new ProductoDao();
            loginDao = new LoginDao();
        }


        //  DOCUMENTO

        public bool CrearDocumento(Documento oPedido)
        {
            return documentoDao.Create(oPedido);
        }

        public bool ActualizarDocumento(Documento oPedido)
        {
            return documentoDao.Update(oPedido);
        }

        public bool BorrarDocumento(int id)
        {
            return documentoDao.Delete(id);
        }

        public List<Documento> ObtenerDocumentosPorFiltro(DateTime desde, DateTime hasta, string cliente)
        {
            return documentoDao.GetDocumentosPorFiltro(desde, hasta, cliente);
        }

        public Documento ObtenerDocumentoPorId(int id)
        {
            return documentoDao.GetDocumentoPorId(id);
        }


        //  PRODUCTO

        public List<Producto> ObtenerProductos()
        {
            return productoDao.GetProductos();
        }

        public bool CrearProducto(Producto oProducto)
        {
            return productoDao.CreateProducto(oProducto);
        }

        public DataTable ObtenerReporteProductosListado()
        {
            return productoDao.GetReporteProductosListado();
        }

        public DataTable ObtenerReporteProductos(DateTime desde, DateTime hasta)
        {
            return productoDao.GetReporteProductos(desde, hasta);
        }


        //  LOGIN


        public LoginDTO Login(List<Parametro> credenciales)
        {
            return loginDao.Login(credenciales);  
        }

        
    }
}
