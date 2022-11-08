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
            cboProductos.SelectedIndex = -1;
            txtMarca.Enabled = false;
            txtPrecio.Enabled = false;
            txtStock.Enabled = false;
            txtCarroceria.Enabled = false;
            txtColor.Enabled = false;
            txtAnio.Enabled = false;
        }

        private async Task CargarComboAsync()
        {
            var result = await ClienteSingleton.ObtenerInstancia().GetAsync("http://localhost:5008/api/Producto/Consultar");

            //List<Producto> lst = JsonConvert.DeserializeObject<List<Producto>>(result);
            productosCargados = JsonConvert.DeserializeObject<List<Producto>>(result);

            
            cboProductos.DataSource = productosCargados;
            cboProductos.DisplayMember = "Modelo";
            cboProductos.ValueMember = "Id_producto";

            
        }

        private void grupo_Nuevo_Presupuesto_Enter(object sender, EventArgs e)
        {

            
        }

        

        private void cboProductos_Leave(object sender, EventArgs e)
        {
            
            txtMarca.Text      = productosCargados[cboProductos.SelectedIndex].Marca;
            txtCarroceria.Text = productosCargados[cboProductos.SelectedIndex].Descripcion;
            txtStock.Text      = productosCargados[cboProductos.SelectedIndex].Stock.ToString();
            txtColor.Text      = productosCargados[cboProductos.SelectedIndex].Color;
            txtAnio.Text       = productosCargados[cboProductos.SelectedIndex].Anio.ToString();
            txtPrecio.Text     = productosCargados[cboProductos.SelectedIndex].Precio_Vta.ToString();

            var prueba = 2;
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cboProductos.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un vehículo.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboProductos.Focus();
                return;
            }
            var producto = (Producto)cboProductos.SelectedItem;
            if (dgvDetalles.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvDetalles.Rows)
                {
                    if (row.Cells[2].Value.ToString() == producto.Modelo.ToString())
                    {
                        if (Convert.ToInt32(row.Cells[7].Value) == Convert.ToInt32(txtStock.Text))
                        {
                            MessageBox.Show("La cantidad cargada alcanzó al stock disponible.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        else
                        {
                            row.Cells[7].Value = Convert.ToString((Convert.ToInt32(row.Cells[7].Value)) + 1);
                            var prue = 2;

                        }
                        dgvDetalles.Refresh();
                        return;
                    }
                }
            } else
            {
                dgvDetalles.Rows.Add(producto.Id_Producto,producto.Marca, producto.Modelo, producto.Descripcion, producto.Color, producto.Anio,producto.Precio_Vta, producto.Precio_Vta/producto.Precio_Vta);
            }
            
        }
    }
}
