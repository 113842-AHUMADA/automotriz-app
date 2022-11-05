using AutomotrizApp.datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomotrizBack.datos.interfaces;

namespace AutomotrizBack.datos.implementaciones
{
    internal class LoginDao : ILoginDao
    {
        public string Login(List<Parametro> credenciales)
        {

            string respuesta;
            SqlConnection conexion = HelperDao.ObtenerInstancia().ObtenerConexion();

            try
            {
                if (conexion.State == (System.Data.ConnectionState)1)
                {
                    conexion.Close();
                }
                conexion.Open();


                SqlCommand cmdLogin = new SqlCommand("SP_INGRESAR", conexion);
                cmdLogin.CommandType = CommandType.StoredProcedure;

                if (credenciales != null)
                {
                    foreach (Parametro param in credenciales)
                    {
                        cmdLogin.Parameters.AddWithValue(param.Clave, param.Valor.ToString());
                    }
                }
                
                SqlParameter parametro = new SqlParameter("@privilegio", SqlDbType.VarChar, 20);
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
