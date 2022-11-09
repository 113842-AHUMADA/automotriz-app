using AutomotrizApp.dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomotrizBack.datos;
using System.ComponentModel;

namespace AutomotrizApp.datos
{
    internal class HelperDao
    {
        private static HelperDao instancia;
        private SqlConnection conexion;

        private HelperDao()
        {
            conexion = new SqlConnection(AutomotrizBack.Properties.Resources.ConnectionStringLucas);
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

        public DataTable Consultar(string nombreSP, List<Parametro> values)
        {
            DataTable tabla = new DataTable();

            if (conexion.State == (System.Data.ConnectionState)1)
            {
                conexion.Close();
            }
            conexion.Open();

            SqlCommand cmd = new SqlCommand(nombreSP, conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            if (values != null)
            {
                foreach (Parametro oParametro in values)
                {
                    cmd.Parameters.AddWithValue(oParametro.Clave, oParametro.Valor.ToString());
                }
            }
            tabla.Load(cmd.ExecuteReader());
            conexion.Close();

            return tabla;
        }

        internal bool Ejecutar(string sp, List<Parametro> values)
        {
            bool respuesta = false;
            SqlTransaction transaccion = null;

            try
            {
                conexion.Open();
                transaccion = conexion.BeginTransaction();
                SqlCommand cmd = new SqlCommand(sp,conexion,transaccion);
                cmd.CommandType = CommandType.StoredProcedure;

                if (values != null)
                {
                    foreach (Parametro param in values)
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
