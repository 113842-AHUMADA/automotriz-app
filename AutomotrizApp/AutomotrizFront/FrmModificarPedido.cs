using AutomotrizApp.dominio;
using AutomotrizBack.datos;
using AutomotrizFront.Http;
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
    public partial class FrmModificarPedido : Form
    {
        private List<Producto> productos;
        private Documento nuevo;
        public FrmModificarPedido(int id,string cliente)
        {
            InitializeComponent();
            nuevo = new Documento();
            nuevo.Cliente = cliente;
            nuevo.Id_Documento = id;
        }

        private async void FrmModificarPedido_Load(object sender, EventArgs e)
        {
            await CargarComboAsync();
            this.Text = this.Text + " | MODIFICACION DEL PEDIDO NRO: " + nuevo.Id_Documento.ToString();
            cboProductos.DropDownStyle = ComboBoxStyle.DropDownList;
            txtEmpleado.Enabled = true;
            txtCliente.Enabled = false;
            txtCliente.Text = nuevo.Cliente.ToString();
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
            productos = JsonConvert.DeserializeObject<List<Producto>>(result);

            cboProductos.DataSource = productos;
            cboProductos.DisplayMember = "Modelo";
            cboProductos.ValueMember = "Id_producto";
        }
               
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (cboProductos.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un vehículo.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cboProductos.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debe seleccionar un modelo!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            foreach (DataGridViewRow row in dgvDetalles.Rows)
            {
                if (dgvDetalles.Rows.Count > 0)
                {
                    if (row.Cells["col_modelo"].Value.ToString().Equals(cboProductos.Text))
                    {
                        MessageBox.Show("El modelo " + cboProductos.Text + " ya se encuentra como detalle!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;

                    }
                }
               
            }
            
             Producto producto = (Producto)cboProductos.SelectedItem;
             int cantidad = Convert.ToInt32(updCantidad.Value);

             Detalle detalle = new Detalle(producto, cantidad);
             nuevo.AgregarDetalle(detalle);
             dgvDetalles.Rows.Add(new object[] { producto.Id_Producto, producto.Marca, producto.Modelo, producto.Descripcion, producto.Color, producto.Anio, producto.Precio_Vta, producto.Precio_Vta });
            

             CalcularTotal();
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtCliente.Text == "")
            {
                MessageBox.Show("Debe ingresar un cliente!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (dgvDetalles.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos detalle!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            await ActualizarDocumentoAsync();

        }

        private async Task ActualizarDocumentoAsync()
        {
            
            nuevo.Vendedor = txtEmpleado.Text;
            nuevo.Fecha_Entrega = Convert.ToDateTime(dtpFechaEntrega.Text);
            nuevo.Fecha_Documento = DateTime.Today;
            string pedidoJSON = JsonConvert.SerializeObject(nuevo);

            string url = "http://localhost:5008/api/Documento/actualizar";
            var result = await ClienteSingleton.ObtenerInstancia().PutAsync(url, pedidoJSON);

            if (result.Equals("true"))
            {
                MessageBox.Show("Pedido registrado con éxito!", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("ERROR. No se pudo registrar el presupuesto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalles.CurrentCell.ColumnIndex == 8)
            {
                nuevo.QuitarDetalle(dgvDetalles.CurrentRow.Index);
                dgvDetalles.Rows.Remove(dgvDetalles.CurrentRow);
                CalcularTotal();

            }
        }

        private void CalcularTotal()
        {
            double total = nuevo.CalcularTotal();
            txtCalculo.Text = total.ToString();

        }

        private void cboProductos_Leave(object sender, EventArgs e)
        {
            txtMarca.Text = productos[cboProductos.SelectedIndex].Marca;
            txtCarroceria.Text = productos[cboProductos.SelectedIndex].Descripcion;
            txtStock.Text = productos[cboProductos.SelectedIndex].Stock.ToString();
            txtColor.Text = productos[cboProductos.SelectedIndex].Color;
            txtAnio.Text = productos[cboProductos.SelectedIndex].Anio.ToString();
            txtPrecio.Text = productos[cboProductos.SelectedIndex].Precio_Vta.ToString();
        }
    }
}
