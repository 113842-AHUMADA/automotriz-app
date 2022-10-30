using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutomotrizBack.negocio;
using AutomotrizBack.negocio.implementaciones;

namespace AutomotrizFront
{
    public partial class FrmLogin : Form
    {
        Aplicacion oAplicacion = new Aplicacion();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void LinkLblOlvido_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Por favor, póngase en contacto con el área de soporte enviando un correo a 'Soporte@Automotriz.com' indicando credenciales de empleado y nombre de usuario.", "Recuperación de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Debe indicar los valores de usuario y contraseña", "Complete los campos de acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string nivelPrivilegio = oAplicacion.Login(txtUsuario.Text, txtPassword.Text);
            if (nivelPrivilegio == "Usuario Incorrecto")
            {
                MessageBox.Show("El usuario y/o contraseña no es válido.", "Credenciales incorrectas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Clear();
                txtPassword.Clear();
                txtUsuario.Focus();
            }
            else
            {
                FrmHome home = new FrmHome();
                this.Close();
                home.ShowDialog();
            }
        }
    }
}
