using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutomotrizBack.datos;
using AutomotrizBack.negocio;
using AutomotrizBack.negocio.implementaciones;
using AutomotrizFront.Http;
using Newtonsoft.Json;

namespace AutomotrizFront
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void LinkLblOlvido_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Por favor, póngase en contacto con el área de soporte enviando un correo a 'Soporte@Automotriz.com' indicando credenciales de empleado y nombre de usuario.", "Recuperación de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        

        private async void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Debe indicar los valores de usuario y contraseña", "Complete los campos de acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            loginDTO Usuario_logeado = new loginDTO();
            Usuario_logeado = await this.ConsultarIngreso();
            

            if (Usuario_logeado.privilegio == "Usuario Incorrecto")
            {
                MessageBox.Show("El usuario y/o contraseña no es válido.", "Credenciales incorrectas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Clear();
                txtPassword.Clear();
                txtUsuario.Focus();
            }
            else
            {
                FrmHome home = new FrmHome(Usuario_logeado);
                this.Hide();
                home.ShowDialog();
            }
        }


        //http://localhost:5008/api/Login/ingresar?usuario=admin&password=admin

        private async Task<loginDTO> ConsultarIngreso()
        {
            List <Parametro> credenciales = new List<Parametro>();
            credenciales.Add(new Parametro("@usuario", txtUsuario.Text));
            credenciales.Add(new Parametro("@contrasenia", txtPassword.Text));
            string credencialesJSON = JsonConvert.SerializeObject(credenciales);
            var result = await ClienteSingleton.ObtenerInstancia().PostAsync("http://localhost:5008/api/Login/ingresar", credencialesJSON);
            return result;
        }







        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
