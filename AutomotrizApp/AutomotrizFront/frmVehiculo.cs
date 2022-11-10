using AutomotrizApp.dominio;
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
    public partial class frmVehiculo : Form
    {
        private string[] listaTipos = new string[4];
        private Producto vehiculo = new();
        private List<Producto> productosCargados;
        private bool actualizar = false;
        public frmVehiculo()
        {
            InitializeComponent();
            
            listaTipos[0] = "Coupe";
            listaTipos[1] = "Urbano";
            listaTipos[2] = "Sedan";
            listaTipos[3] = "Pickup";
            cboDescripcion.SelectedIndex = -1;
        }

        private async Task CargarComboAsync()
        {
            var result = await ClienteSingleton.ObtenerInstancia().GetAsync("http://localhost:5008/api/Producto/Consultar");

            //List<Producto> lst = JsonConvert.DeserializeObject<List<Producto>>(result);
            productosCargados = JsonConvert.DeserializeObject<List<Producto>>(result);


            lstbxProductos.DataSource = productosCargados;
            lstbxProductos.DisplayMember = "Modelo";
            lstbxProductos.ValueMember = "Id_producto";



        }

        private async void frmVehiculo_Load(object sender, EventArgs e)
        {
            cboDescripcion.DataSource = listaTipos;
            await CargarComboAsync();
        }

        private async void btnGrabar_Click(object sender, EventArgs e)
        {
            if (txtAnio.Text == "" || txtMarca.Text == "" || txtModelo.Text == "" || txtColor.Text == "" || txtAnio.Text == "" || txtPrecio.Text == "" || cboDescripcion.SelectedIndex == -1)
            {
                MessageBox.Show("Debe rellenar todos los campos para grabar el vehículo!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (actualizar)
            {
                vehiculo.Id_Producto = (int)lstbxProductos.SelectedValue;
            } else
            {
                vehiculo.Id_Producto = DateTime.Now.Millisecond / DateTime.Now.Millisecond + 20;
            }
            
            vehiculo.Anio = Convert.ToInt32(txtAnio.Text);
            vehiculo.Marca = txtMarca.Text;
            vehiculo.Modelo = txtModelo.Text;
            vehiculo.Descripcion = cboDescripcion.SelectedValue.ToString();
            vehiculo.Precio_Vta = Convert.ToDouble(txtPrecio.Text);
            vehiculo.Color = txtColor.Text;
            vehiculo.Stock = Convert.ToInt32(txtStock.Text);
            vehiculo.Stock_Critico = Convert.ToInt32(txtStockCritico.Text);
            if (actualizar)
            {
                var result = this.ActualizarVehiculoAsync();
            }
            else
            {
                var result = this.GrabarVehiculoAsync();
            }
            this.Refresh();
        }

        private async Task GrabarVehiculoAsync()
        {


            string pedidoJSON = JsonConvert.SerializeObject(vehiculo);
            string url = "http://localhost:5008/api/Producto/Crear";
            var result = await ClienteSingleton.ObtenerInstancia().PostAsyncDefault(url, pedidoJSON);
           
            if (result.Equals("true"))
            {
                MessageBox.Show("Se realizó la operación con éxito!", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("ERROR. No se pudo realizar la operación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task ActualizarVehiculoAsync()
        {


            string pedidoJSON = JsonConvert.SerializeObject(vehiculo);


            string url = "http://localhost:5008/api/Producto/Actualizar";
                var result = await ClienteSingleton.ObtenerInstancia().PutAsync(url, pedidoJSON);
            



            if (result.Equals("true"))
            {
                MessageBox.Show("Se realizó la operación con éxito!", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("ERROR. No se pudo realizar la operación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("¿Está seguro que desea eliminar este vehículo?", "Salir", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            int id = (int)lstbxProductos.SelectedValue;
           

            if (await BorrarVehiculoAsync(id))
            {
                MessageBox.Show("El vehículo se eliminó exitosamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Refresh();
            }
            else
            {
                MessageBox.Show("El vehículo NO se eliminó exitosamente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<bool> BorrarVehiculoAsync(int id)
        {

            var result = await ClienteSingleton.ObtenerInstancia().DeleteAsync("http://localhost:5008/api/Producto/eliminar/" + id);
            bool respuesta = JsonConvert.DeserializeObject<bool>(result);
            return respuesta;
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            this.limpiar();
            txtMarca.Enabled = true;
            txtModelo.Enabled = true;
            cboDescripcion.SelectedIndex = -1;
            txtColor.Enabled = true;
            txtAnio.Enabled = true;
            txtPrecio.Enabled = true;
            txtStock.Enabled = true;


            txtMarca.Text = productosCargados[(int)lstbxProductos.SelectedValue-1].Marca;
            txtModelo.Text = productosCargados[(int)lstbxProductos.SelectedValue - 1].Modelo;
            cboDescripcion.SelectedIndex = (int)lstbxProductos.SelectedValue;
            txtColor.Text = productosCargados[(int)lstbxProductos.SelectedValue - 1].Color;
            txtAnio.Text = productosCargados[(int)lstbxProductos.SelectedValue - 1].Anio.ToString();
            txtPrecio.Text = productosCargados[(int)lstbxProductos.SelectedValue - 1].Precio_Vta.ToString();
            txtStock.Text = productosCargados[(int)lstbxProductos.SelectedValue - 1].Stock.ToString();
            txtStockCritico.Text = productosCargados[(int)lstbxProductos.SelectedValue - 1].Stock_Critico.ToString();

            if (txtAnio.Text == "" || txtMarca.Text == "" || txtModelo.Text == "" || txtColor.Text == "" || txtAnio.Text == "" || txtPrecio.Text == "" || cboDescripcion.SelectedIndex == -1)
            {
                MessageBox.Show("Debe rellenar todos los campos para grabar el vehículo!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            actualizar = true;

        }

        private void limpiar()
        {
            txtMarca.Clear();
            txtModelo.Clear();
            cboDescripcion.SelectedIndex = -1;
            txtColor.Clear();
            txtAnio.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
        }
    }
}
