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

        bool CreateProducto(Producto oProducto);

        bool UpdateProducto(Producto oProducto);

        bool DeleteProducto(int id);

        DataTable GetReporteProductosListado();

        DataTable GetReporteProductosAgrupado(List<Parametro> filtros);

    }
}
