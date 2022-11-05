using AutomotrizApp.datos;
using AutomotrizApp.dominio;
using AutomotrizBack.datos.interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.datos.implementaciones
{
    class ProductoDao : IProductoDao
    {
        public List<Producto> GetProductos()
        {
            List<Producto> lista = new List<Producto>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("SP_CONSULTAR_PRODUCTOS", null);

            foreach (DataRow fila in tabla.Rows)
            {
                Producto prod = new Producto();
                prod.Id_Producto = (int)fila["id_producto"];
                prod.Marca = fila["marca"].ToString();
                prod.Modelo = fila["modelo"].ToString();
                prod.Descripcion = fila["descripcion"].ToString();
                prod.Color = fila["color"].ToString();
                prod.Anio = (int)fila["anio"];
                prod.Stock = (int)fila["stock"];
                prod.Stock_Critico = (int)fila["stock_critico"];
                prod.Precio_Vta = Convert.ToDouble(fila["precio_vta"]);

                lista.Add(prod);
            }
            return lista;
        }

        public DataTable GetReporteProductosListado()
        {
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("SP_REPORTE_PRODUCTOS_LISTADO", null);
            return tabla;
        }

        public DataTable GetReporteProductos(DateTime desde, DateTime hasta)
        {
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@fecha_desde", desde));
            lst.Add(new Parametro("@fecha_hasta", hasta));
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("SP_REPORTE_PRODUCTOS_AGRUPACION", lst);
            return tabla;
        }



        //alta vehiculo









    }
}
