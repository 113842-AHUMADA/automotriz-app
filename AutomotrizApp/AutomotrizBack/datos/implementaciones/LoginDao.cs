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
        public LoginDTO Login(List<Parametro> credenciales)
        {

            LoginDTO respuesta = new LoginDTO();
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

                // Lucas: Esto está de más, ya que en el front se controla que si o si se envín credenciales
                // Fede: Entendido. Me parecio interesante dejarlo por el hecho que son proyectos independientes. Nada me asegura
                //      que la persona que este haciendo la peticion, haya hecho las validaciones correctas. 
                //      Aporta valor conceptual mas que funcional.
                if (credenciales != null)
                {
                    foreach (Parametro param in credenciales)
                    {
                        cmdLogin.Parameters.AddWithValue(param.Clave, param.Valor.ToString());
                    }
                }
                
                SqlParameter paramPrivilegio = new SqlParameter("@privilegio", SqlDbType.VarChar, 20);
                paramPrivilegio.Direction = ParameterDirection.Output;
                cmdLogin.Parameters.Add(paramPrivilegio);

                SqlParameter paramNombreApellido = new SqlParameter("@nombreApellido", SqlDbType.VarChar, 60);
                paramNombreApellido.Direction = ParameterDirection.Output;
                cmdLogin.Parameters.Add(paramNombreApellido);

                SqlParameter paramIdCredencial = new SqlParameter("@Id_Credencial", SqlDbType.Int);
                paramIdCredencial.Direction = ParameterDirection.Output;
                cmdLogin.Parameters.Add(paramIdCredencial);

                cmdLogin.ExecuteNonQuery();

                if (paramPrivilegio.Value.ToString() == "")
                    respuesta.privilegio = "Usuario Incorrecto";
                else
                {
                    respuesta.privilegio = paramPrivilegio.Value.ToString()!;
                    respuesta.nombreApellido = paramNombreApellido.Value.ToString()!;
                    respuesta.id_credencial = Convert.ToInt32(paramIdCredencial.Value);
                }
            }
            catch (SqlException ex)
            {
                respuesta.privilegio = "Ocurrió un error al conectarse a la base de datos. " + ex.Message;
                return respuesta;
            }
            return respuesta;
        }

    }
}
