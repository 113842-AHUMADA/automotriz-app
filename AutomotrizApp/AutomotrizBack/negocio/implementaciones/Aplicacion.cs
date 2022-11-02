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
        private IDocumentoDao oDao;

        public Aplicacion()
        {
            oDao = new DocumentoDao();
        }

        public List<Producto> ObtenerProductos()
        {
            return oDao.GetProductos();
        }

        public bool CrearDocumento(Documento oPedido)
        {
            return oDao.Create(oPedido);
        }

        public bool ActualizarDocumento(Documento oPedido)
        {
            return oDao.Update(oPedido);
        }

        public bool BorrarDocumento(int id)
        {
            return oDao.Delete(id);
        }

        public List<Documento> ObtenerDocumentosPorFiltro(DateTime desde, DateTime hasta, string cliente)
        {
            return oDao.GetDocumentosPorFiltro(desde, hasta, cliente);
        }

        public Documento ObtenerDocumentoPorId(int id)
        {
            return oDao.GetDocumentoPorId(id);
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
