using AutomotrizApp.datos;
using AutomotrizApp.dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.datos.interfaces
{
    interface IProductoDao
    {
        List<Producto> GetProductos();

        DataTable GetReporteProductosListado();

        DataTable GetReporteProductos(DateTime desde, DateTime hasta);

    }
}
