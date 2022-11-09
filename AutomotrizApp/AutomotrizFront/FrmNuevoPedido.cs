using AutomotrizApp.dominio;
using AutomotrizBack.datos;
using AutomotrizFront.Http;
using Microsoft.CodeAnalysis.FlowAnalysis;
using Microsoft.Reporting.WinForms;
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
        private Documento documentoAEnviar = new();
        public FrmNuevoPedido(LoginDTO usuario)
        {
            this.usuario_logueado = usuario;
            InitializeComponent();
        }

        private async void FrmNuevoPedido_Load(object sender, EventArgs e)
        {
            await CargarComboAsync();
            txtTotal.Text = "0";
            txtTotal.Enabled = false;
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

        private async Task GrabarDocumentoAsync()
        {

            documentoAEnviar.Id_Documento = 3;
            documentoAEnviar.Vendedor = txtEmpleado.Text;
            documentoAEnviar.Cliente = txtCliente.Text;
            documentoAEnviar.Fecha_Entrega = Convert.ToDateTime(dtpFechaEntrega.Text);
            documentoAEnviar.Fecha_Documento = DateTime.Today;
            string pedidoJSON = JsonConvert.SerializeObject(documentoAEnviar);

            string url = "http://localhost:5008/api/Documento/Crear";
            var result = await ClienteSingleton.ObtenerInstancia().PostAsyncDefault(url, pedidoJSON);

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
        private void grupo_Nuevo_Presupuesto_Enter(object sender, EventArgs e)
        {


        }



        private void cboProductos_Leave(object sender, EventArgs e)
        {

            txtMarca.Text = productosCargados[cboProductos.SelectedIndex].Marca;
            txtCarroceria.Text = productosCargados[cboProductos.SelectedIndex].Descripcion;
            txtStock.Text = productosCargados[cboProductos.SelectedIndex].Stock.ToString();
            txtColor.Text = productosCargados[cboProductos.SelectedIndex].Color;
            txtAnio.Text = productosCargados[cboProductos.SelectedIndex].Anio.ToString();
            txtPrecio.Text = productosCargados[cboProductos.SelectedIndex].Precio_Vta.ToString();

            var prueba = 2;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int Total_venta = 0;
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
                            Total_venta = Convert.ToInt32(txtTotal.Text)+ Convert.ToInt32(row.Cells[6].Value);
                        }
                        txtTotal.Text = Total_venta.ToString();
                        dgvDetalles.Refresh();
                        return;
                    }
                }
                    dgvDetalles.Rows.Add(producto.Id_Producto, producto.Marca, producto.Modelo, producto.Descripcion, producto.Color, producto.Anio, producto.Precio_Vta, 1);
                    Total_venta = Convert.ToInt32(txtTotal.Text) + (int)producto.Precio_Vta;
                    txtTotal.Text = Total_venta.ToString();
                    return;
            }
            else
            {
                dgvDetalles.Rows.Add(producto.Id_Producto, producto.Marca, producto.Modelo, producto.Descripcion, producto.Color, producto.Anio, producto.Precio_Vta, 1);
                Total_venta = Convert.ToInt32(txtTotal.Text) + (int)producto.Precio_Vta;
                txtTotal.Text = Total_venta.ToString();
                return;

            }
            

        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int totalActual = Convert.ToInt32(txtTotal.Text);
            int totalNuevo;
            var na = dgvDetalles.CurrentCell;
            if (e.ColumnIndex == 8)
            {
                if (dgvDetalles.CurrentRow.Cells[7].Value.ToString() == "1")
                {
                    totalNuevo = totalActual - Convert.ToInt32(dgvDetalles.CurrentRow.Cells[6].Value);
                    dgvDetalles.Rows.RemoveAt(e.RowIndex);
                    txtTotal.Text = totalNuevo.ToString();
                    return;
                }
                string cantActual = dgvDetalles.CurrentRow.Cells[7].Value.ToString();
                int cantNueva = Convert.ToInt32(cantActual) - 1;
                dgvDetalles.CurrentRow.Cells[7].Value = cantNueva.ToString();
                totalNuevo = totalActual - Convert.ToInt32(dgvDetalles.CurrentRow.Cells[6].Value);
                txtTotal.Text = totalNuevo.ToString();
            }
        }

        private async void btnGrabar_Click(object sender, EventArgs e)
        {
            if (txtCliente.Text == "")
            {
                MessageBox.Show("Debe ingresar el nombre del cliente.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTotal.Text == "0")
            {
                MessageBox.Show("Debe cargar al menos un vehículo al pedido.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (DataGridViewRow detalle in dgvDetalles.Rows)
            {
                Detalle detalleDocumento = new Detalle();
                detalleDocumento.Cantidad = Convert.ToInt32(detalle.Cells[7].Value);
                Producto prodDetalle = new();

                prodDetalle.Id_Producto = (int)detalle.Cells[0].Value;
                prodDetalle.Marca = detalle.Cells[1].Value.ToString();
                prodDetalle.Modelo = detalle.Cells[2].Value.ToString();
                prodDetalle.Descripcion = detalle.Cells[3].Value.ToString();
                prodDetalle.Color = detalle.Cells[4].Value.ToString();
                prodDetalle.Anio   = (int)detalle.Cells[5].Value;
                prodDetalle.Precio_Vta = (double)detalle.Cells[6].Value;


                detalleDocumento.Producto = prodDetalle;
                documentoAEnviar.AgregarDetalle(detalleDocumento);
            }
            await GrabarDocumentoAsync();
            
        }
    }
    }
