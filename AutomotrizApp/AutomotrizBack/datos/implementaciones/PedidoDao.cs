using AutomotrizApp.datos.interfaces;
using AutomotrizApp.dominio;
using AutomotrizBack.datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace AutomotrizApp.datos.implementaciones
{
    class PedidoDao : IPedidoDao
    {
        public List<Producto> GetProductos()
        {
            List<Producto> lista = new List<Producto>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("SP_CONSULTAR_PRODUCTOS",null);

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

        public bool Create(Pedido oPedido)
        {
            bool respuesta = false;
            SqlConnection conexion = HelperDao.ObtenerInstancia().ObtenerConexion();
            SqlTransaction transaccion = null;

            try
            {
                conexion.Open();
                transaccion = conexion.BeginTransaction();

                SqlCommand cmdMaestro = new SqlCommand("SP_INSERTAR_DOCUMENTOS", conexion, transaccion);
                cmdMaestro.CommandType = CommandType.StoredProcedure;
                cmdMaestro.Parameters.AddWithValue("@tipo_documento", "pedido");
                cmdMaestro.Parameters.AddWithValue("@empleado", oPedido.Vendedor); 
                cmdMaestro.Parameters.AddWithValue("@cliente", oPedido.Cliente);
                cmdMaestro.Parameters.AddWithValue("@fecha_entrega", oPedido.Fecha_Entrega);

                SqlParameter parametro = new SqlParameter("@id_documento", SqlDbType.Int);
                parametro.Direction = ParameterDirection.Output;
                cmdMaestro.Parameters.Add(parametro);
                cmdMaestro.ExecuteNonQuery();

                int idPedido = Convert.ToInt32(parametro.Value);

                foreach (Detalle item in oPedido.lstDetalle)
                {
                    SqlCommand cmdDetalle = new SqlCommand("SP_INSERTAR_DETALLES", conexion, transaccion);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@id_pedido", idPedido);
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

        public bool Update(Pedido oPedido)
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
                cmdMaestro.Parameters.AddWithValue("@tipo_documento", "pedido");
                cmdMaestro.Parameters.AddWithValue("@empleado", oPedido.Vendedor);
                cmdMaestro.Parameters.AddWithValue("@cliente", oPedido.Cliente);
                cmdMaestro.Parameters.AddWithValue("@fecha_entrega", oPedido.Fecha_Entrega);

                SqlParameter parametro = new SqlParameter("@id_documento", SqlDbType.Int);
                parametro.Direction = ParameterDirection.Output;
                cmdMaestro.Parameters.Add(parametro);
                cmdMaestro.ExecuteNonQuery();

                int idPedido = Convert.ToInt32(parametro.Value);

                foreach (Detalle item in oPedido.lstDetalle)
                {
                    SqlCommand cmdDetalle = new SqlCommand("SP_INSERTAR_DETALLES", conexion, transaccion);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@id_documento", idPedido);
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
            string SP = "SP_ELIMINAR_DOCUMENTO";
            List<Parametro> lst = new List<Parametro>();
            bool eliminado = HelperDao.ObtenerInstancia().Ejecutar(SP, lst);
            return eliminado;
        }

        public List<Pedido> GetPedidosPorFiltro(DateTime desde, DateTime hasta, string cliente)
        {
            //List<Pedido> presupestos = new List<Pedido>();
            //string SP = "SP_CONSULTAR_DOCUMENTOS";
            //List<Parametro> lst = new List<Parametro>();
            //lst.Add(new Parametro("@fecha_desde", desde));
            //lst.Add(new Parametro("@fecha_hasta", hasta));
            //lst.Add(new Parametro("@cliente", cliente));
            //DataTable dt = HelperDao.ObtenerInstancia().Consultar(SP, lst);

            //foreach (DataRow row in dt.Rows)
            //{
            //    Pedido pedido = new Pedido();
            //    pedido.Cliente = row["cliente"].ToString();
            //    pedido.PresupuestoNro = int.Parse(row["presupuesto_nro"].ToString());
            //    pedido.Fecha = DateTime.Parse(row["fecha"].ToString());
            //    pedido.Descuento = double.Parse(row["descuento"].ToString());
            //    pedido.Add(pedido);
            //}

            //return presupestos;
            throw new NotImplementedException();
        }

        public Pedido GetPedidoPorId(int id)
        {
            throw new NotImplementedException();
        }

        public DataTable GetReporteProductos(DateTime desde, DateTime hasta)
        {
            throw new NotImplementedException();
        }

        public string Login(string usuario, string password){

            string respuesta = "";
            SqlConnection conexion = HelperDao.ObtenerInstancia().ObtenerConexion();
            
            try
            {
                conexion.Open();
                

                SqlCommand cmdLogin = new SqlCommand("SP_INGRESAR", conexion);
                cmdLogin.CommandType = CommandType.StoredProcedure;
                cmdLogin.Parameters.AddWithValue("@usuario", usuario);
                cmdLogin.Parameters.AddWithValue("@contrasenia", password);

                SqlParameter parametro = new SqlParameter("@privilegio", SqlDbType.VarChar,20);
                parametro.Direction = ParameterDirection.Output;
                cmdLogin.Parameters.Add(parametro);
                cmdLogin.ExecuteNonQuery();



                if (parametro.Value.ToString() == "")
                    respuesta = "Usuario Incorrecto";
                else
                {
                    respuesta = parametro.Value.ToString()!;
                }
            }
            catch (SqlException ex)
            {
                return "Ocurrió un error al conectarse a la base de datos. " + ex.Message;
            }
            return respuesta;
        }
    }
}
