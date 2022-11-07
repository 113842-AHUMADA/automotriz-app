using AutomotrizApp.dominio;
using AutomotrizBack.datos;
using AutomotrizFront.Http;
using Microsoft.CodeAnalysis.FlowAnalysis;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomotrizFront
{
    public partial class FrmNuevoPedido : Form
    {
        private LoginDTO usuario_logueado;
        private List<Producto> productosCargados;
        public FrmNuevoPedido(LoginDTO usuario)
        {
            this.usuario_logueado = usuario;
            InitializeComponent();
        }

        private async void FrmNuevoPedido_Load(object sender, EventArgs e)
        {
            await CargarComboAsync();
            txtEmpleado.Text = usuario_logueado.nombreApellido;
            txtEmpleado.Enabled = false;
        }

        private async Task CargarComboAsync()
        {
            var result = await ClienteSingleton.ObtenerInstancia().GetAsync("http://localhost:5008/api/Producto/Consultar");

            //List<Producto> lst = JsonConvert.DeserializeObject<List<Producto>>(result);
            productosCargados = JsonConvert.DeserializeObject<List<Producto>>(result);

            
            cboProductos.DataSource = productosCargados;
            cboProductos.DisplayMember = "Descripcion";
            cboProductos.ValueMember = "Id_producto";

            
        }

        private void grupo_Nuevo_Presupuesto_Enter(object sender, EventArgs e)
        {

            
        }

        

        private void cboProductos_Leave(object sender, EventArgs e)
        {
            
            txtMarca.Text = productosCargados[cboProductos.SelectedIndex].Marca;
            var prueba = 2;
            
        }
    }
}
