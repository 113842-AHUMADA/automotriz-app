using AutomotrizApp.datos;
using AutomotrizApp.dominio;
using AutomotrizBack.datos.interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

        public bool CreateProducto(Producto oProducto)
        {
            bool respuesta;
            SqlConnection conexion = HelperDao.ObtenerInstancia().ObtenerConexion();

            try
            {
                conexion.Open();

                SqlCommand cmd = new SqlCommand("SP_INSERTAR_PRODUCTO", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", oProducto.Id_Producto); //Darle valor constante porque el id_producto de DB es identity 
                cmd.Parameters.AddWithValue("@marca", oProducto.Marca);
                cmd.Parameters.AddWithValue("@modelo", oProducto.Modelo);
                cmd.Parameters.AddWithValue("@descripcion", oProducto.Descripcion);
                cmd.Parameters.AddWithValue("@color", oProducto.Color);
                cmd.Parameters.AddWithValue("@anio", oProducto.Anio);
                cmd.Parameters.AddWithValue("@stock", oProducto.Stock);
                cmd.Parameters.AddWithValue("@stock_critico", oProducto.Stock_Critico);
                cmd.Parameters.AddWithValue("@precio_vta", oProducto.Precio_Vta);

                cmd.ExecuteNonQuery();

                respuesta = true;
            }
            catch (SqlException)
            {
                respuesta = false;
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            return respuesta;

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










    }
}
