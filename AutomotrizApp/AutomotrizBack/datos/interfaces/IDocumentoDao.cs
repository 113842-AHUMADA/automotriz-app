using AutomotrizApp.dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizApp.datos.interfaces
{
    interface IDocumentoDao
    {
        List<Producto> GetProductos();

        bool Create(Documento oPedido);

        bool Update(Documento oPedido);

        bool Delete(int id);

        List<Documento> GetDocumentosPorFiltro(DateTime desde, DateTime hasta, string cliente);
        
        Documento GetDocumentoPorId(int id);

        DataTable GetReporteProductos(DateTime desde, DateTime hasta);

        string Login(string usuario, string password);
    }
}
