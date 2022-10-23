using AutomotrizApp.dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomotrizBack.datos;

namespace AutomotrizApp.datos
{
    internal class HelperDao
    {
        private static HelperDao instancia;
        private SqlConnection conexion;

        private HelperDao()
        {
            conexion = new SqlConnection("Data Source=DESKTOP-R46G6B5\\SQLEXPRESS;Initial Catalog=AUTOMOTRIZPROG;Integrated Security=True");
        }

        public static HelperDao ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new HelperDao();
            }
            return instancia;
        }

        public SqlConnection ObtenerConexion()
        {
            return this.conexion;
        }

        public DataTable Consultar(string nombreSP)
        {
            DataTable tabla = new DataTable();

            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;

            tabla.Load(comando.ExecuteReader());

            conexion.Close();
            return tabla;
        }

        internal bool Ejecutar(string sp, List<Parametro> lst)
        {
            bool respuesta = false;
            SqlTransaction transaccion = null;

            try
            {
                conexion.Open();
                transaccion = conexion.BeginTransaction();
                SqlCommand cmd = new SqlCommand(sp,conexion,transaccion);
                cmd.CommandType = CommandType.StoredProcedure;

                if (lst != null)
                {
                    foreach (Parametro param in lst)
                    {
                        cmd.Parameters.AddWithValue(param.Clave, param.Valor);
                    }
                }

                cmd.ExecuteNonQuery();
                
                transaccion.Commit();
                respuesta = true;
            }
            catch (Exception)
            {
                if(conexion!=null)
                transaccion.Rollback();
               
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open )
                conexion.Close();
            }

            return respuesta;
        }
    }
}
