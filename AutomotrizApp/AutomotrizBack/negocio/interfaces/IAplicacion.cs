using AutomotrizApp.dominio;
using AutomotrizBack.datos;
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

        public bool CrearDocumento(Documento oPedido);

        public bool ActualizarDocumento(Documento oPedido);

        public bool BorrarDocumento(int id);

        public List<Documento> ObtenerDocumentosPorFiltro(DateTime desde, DateTime hasta, string cliente);

        public Documento ObtenerDocumentoPorId(int id);

        public DataTable ObtenerReporteProductos(DateTime desde, DateTime hasta);

        public DataTable ObtenerReporteProductosListado();

        public string Login(List<Parametro> credenciales);


    }
}
