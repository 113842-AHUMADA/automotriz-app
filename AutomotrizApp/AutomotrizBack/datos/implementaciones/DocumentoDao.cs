using AutomotrizApp.datos.interfaces;
using AutomotrizApp.dominio;
using AutomotrizBack.datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace AutomotrizApp.datos.implementaciones
{
    class DocumentoDao : IDocumentoDao
    {
        public bool Create(Documento oPedido)
        {
            bool respuesta = false;
            SqlConnection conexion = HelperDao.ObtenerInstancia().ObtenerConexion();
            SqlTransaction transaccion = null;

            try
            {
                if (conexion.State == (System.Data.ConnectionState)1)
                {
                    conexion.Close();
                }
                conexion.Open();
                transaccion = conexion.BeginTransaction();

                SqlCommand cmdMaestro = new SqlCommand("SP_INSERTAR_DOCUMENTOS", conexion, transaccion);
                cmdMaestro.CommandType = CommandType.StoredProcedure;
                cmdMaestro.Parameters.AddWithValue("@id", oPedido.Id_Documento); //Darle valor constante porque el id_documento de DB es identity
                cmdMaestro.Parameters.AddWithValue("@tipo_documento", "pedido");         // hardcodeado
                cmdMaestro.Parameters.AddWithValue("@vendedor", oPedido.Vendedor);      // hardcodeado
                cmdMaestro.Parameters.AddWithValue("@cliente", oPedido.Cliente);       // hardcodeado
                cmdMaestro.Parameters.AddWithValue("@fecha_documento", oPedido.Fecha_Documento);    // dia de hoy
                cmdMaestro.Parameters.AddWithValue("@fecha_entrega", oPedido.Fecha_Entrega);

                SqlParameter parametro = new SqlParameter("@id_documento", SqlDbType.Int);
                parametro.Direction = ParameterDirection.Output;
                cmdMaestro.Parameters.Add(parametro);
                cmdMaestro.ExecuteNonQuery();

                int idDocumento = Convert.ToInt32(parametro.Value);

                foreach (Detalle item in oPedido.lstDetalle)
                {
                    SqlCommand cmdDetalle = new SqlCommand("SP_INSERTAR_DETALLES", conexion, transaccion);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@id_documento", idDocumento);
                    cmdDetalle.Parameters.AddWithValue("@id_producto", item.Producto.Id_Producto);
                    cmdDetalle.Parameters.AddWithValue("@precio_unitario", item.Producto.Precio_Vta);
                    cmdDetalle.Parameters.AddWithValue("@cantidad", item.Cantidad);
                    cmdDetalle.ExecuteNonQuery();
                }

                transaccion.Commit();
                respuesta = true;
            }
            catch (SqlException)
            {
                if (transaccion != null)
                    transaccion.Rollback();
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            return respuesta;

        }

        public bool Update(Documento oPedido)
        {
            bool respuesta = false;
            SqlConnection conexion = HelperDao.ObtenerInstancia().ObtenerConexion();
            SqlTransaction transaccion = null;

            try
            {
                conexion.Open();
                transaccion = conexion.BeginTransaction();

                SqlCommand cmdMaestro = new SqlCommand("SP_ACTUALIZAR_DOCUMENTOS", conexion, transaccion);
                cmdMaestro.CommandType = CommandType.StoredProcedure;
                cmdMaestro.Parameters.AddWithValue("@id_documento", oPedido.Id_Documento);
                cmdMaestro.Parameters.AddWithValue("@vendedor", oPedido.Vendedor);
                cmdMaestro.Parameters.AddWithValue("@cliente", oPedido.Cliente);
                cmdMaestro.Parameters.AddWithValue("@fecha_documento", oPedido.Fecha_Documento);
                cmdMaestro.Parameters.AddWithValue("@fecha_entrega", oPedido.Fecha_Entrega);
                cmdMaestro.ExecuteNonQuery();

                foreach (Detalle item in oPedido.lstDetalle)
                {
                    SqlCommand cmdDetalle = new SqlCommand("SP_INSERTAR_DETALLES", conexion, transaccion);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@id_documento", oPedido.Id_Documento);
                    cmdDetalle.Parameters.AddWithValue("@id_producto", item.Producto.Id_Producto);
                    cmdDetalle.Parameters.AddWithValue("@precio_unitario", item.Producto.Precio_Vta);
                    cmdDetalle.Parameters.AddWithValue("@cantidad", item.Cantidad);
                    cmdDetalle.ExecuteNonQuery();
                }

                transaccion.Commit();
                respuesta = true;
            }
            catch (SqlException)
            {
                if (transaccion != null)
                    transaccion.Rollback();
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            return respuesta;
        }

        public bool Delete(int id)
        {
            bool respuesta;
            SqlConnection conexion = HelperDao.ObtenerInstancia().ObtenerConexion();
            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SP_ELIMINAR_DOCUMENTOS", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_documento",id);
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

        public List<Documento> GetDocumentosPorFiltro(List<Parametro> filtros)
        {
            List<Documento> lstDocumentos = new List<Documento>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("SP_CONSULTAR_DOCUMENTOS", filtros);

            foreach (DataRow fila in tabla.Rows)
            {
                Documento documento = new Documento();
                documento.Id_Documento = int.Parse(fila["id_documento"].ToString());
                documento.Vendedor = fila["vendedor"].ToString();
                documento.Cliente = fila["cliente"].ToString();
                documento.Fecha_Documento = DateTime.Parse(fila["fecha_documento"].ToString());
                documento.Fecha_Entrega = DateTime.Parse(fila["fecha_entrega"].ToString());
                lstDocumentos.Add(documento);
            }

            return lstDocumentos;

        }

        public Documento GetDocumentoPorId(int id)
        {
            Documento documento = new Documento();
            string SP = "SP_CONSULTAR_DOCUMENTOS_CON_DETALLES";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@id_documento", id));

            DataTable tabla = HelperDao.ObtenerInstancia().Consultar(SP, lst);
            bool primero = true;

            foreach (DataRow fila in tabla.Rows)
            {
                if (primero)
                {
                    documento.Vendedor = fila["vendedor"].ToString();
                    documento.Cliente = fila["cliente"].ToString();
                    documento.Fecha_Documento = DateTime.Parse(fila["fecha_documento"].ToString());
                    documento.Fecha_Documento = DateTime.Parse(fila["fecha_entrega"].ToString());
                    primero = false;
                }
                int id_producto = int.Parse(fila["id_producto"].ToString());
                string marca = fila["marca"].ToString();
                string modelo = fila["modelo"].ToString();
                string descripcion = fila["descripcion"].ToString();
                string color = fila["color"].ToString();
                int anio = int.Parse(fila["anio"].ToString());
                double precio_vta = double.Parse(fila["precio_vta"].ToString());

                Producto producto = new Producto(id_producto,marca,modelo,descripcion,color,anio,precio_vta);
                int cantidad = int.Parse(fila["cantidad"].ToString());
                Detalle detalle = new Detalle(producto, cantidad);
                documento.AgregarDetalle(detalle);

            }

            return documento;
        }

    }
}
