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
        public frmVehiculo()
        {
            InitializeComponent();
            listaTipos[0] = "Coupe";
            listaTipos[1] = "Urbano";
            listaTipos[2] = "Sedan";
            listaTipos[3] = "Pickup";
            cboDescripcion.SelectedIndex = -1;
        }

        private void frmVehiculo_Load(object sender, EventArgs e)
        {
            cboDescripcion.DataSource = listaTipos;
        }

        private async void btnGrabar_Click(object sender, EventArgs e)
        {
            if (txtAnio.Text == "" || txtMarca.Text == "" || txtModelo.Text == "" || txtColor.Text == "" || txtAnio.Text == "" || txtPrecio.Text == "" || cboDescripcion.SelectedIndex == -1)
            {
                MessageBox.Show("Debe rellenar todos los campos para grabar el vehículo!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            vehiculo.Id_Producto = DateTime.Now.Hour / DateTime.Now.Hour + 20;
            vehiculo.Anio = Convert.ToInt32(txtAnio.Text);
            vehiculo.Marca = txtMarca.Text;
            vehiculo.Modelo = txtModelo.Text;
            vehiculo.Descripcion = cboDescripcion.SelectedText;
            vehiculo.Precio_Vta = Convert.ToDouble(txtPrecio.Text);
            vehiculo.Color = txtColor.Text;
            var result = this.GrabarVehiculoAsync();
        }

        private async Task GrabarVehiculoAsync()
        {


            string pedidoJSON = JsonConvert.SerializeObject(vehiculo);

            string url = "http://localhost:5008/api/Producto/Crear";
            var result = await ClienteSingleton.ObtenerInstancia().PostAsyncDefault(url, pedidoJSON);

            if (result.Equals("true"))
            {
                MessageBox.Show("Vehículo registrado con éxito!", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("ERROR. No se pudo registrar el vehículo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
