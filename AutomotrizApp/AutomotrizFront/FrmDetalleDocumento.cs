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
    public partial class FrmDetalleDocumento : Form
    {

        private Documento nuevo;


        public FrmDetalleDocumento(int id)
        {
            InitializeComponent();
            this.nuevo = new Documento();
            nuevo.Id_Documento = id;
            //nuevo.Vendedor = vendedor;
            //nuevo.Cliente = cliente;
            //nuevo.Fecha_Entrega = Convert.ToDateTime(fecha_entrega);


        }

        private async void FrmDetalleDocumento_Load(object sender, EventArgs e)
        {
            this.Text = this.Text + " | MODIFICACION DEL PEDIDO NRO: " + nuevo.Id_Documento.ToString();
            
            await CargarGridAsync(nuevo.Id_Documento);
        }


         private async Task CargarGridAsync(int id)
        {
            var result = await ClienteSingleton.ObtenerInstancia().GetAsync("http://localhost:5008/api/Documento/consultar/"+id);

            Documento oDoc = JsonConvert.DeserializeObject<Documento>(result);


            txtEmpleado.Enabled = false;
            txtEmpleado.Text = oDoc.Vendedor;
            txtCliente.Enabled = false;
            txtCliente.Text = oDoc.Cliente;
            txtFechaEntrega.Enabled = false;
            txtFechaEntrega.Text = oDoc.Fecha_Entrega.ToString("dd/MM/yyyy");
            txtFechaDocumento.Enabled = false;
            txtFechaDocumento.Text = oDoc.Fecha_Documento.ToString("dd/MM/yyyy");

            foreach (Detalle detalle in oDoc.lstDetalle)
            {
                dgvDetalles.Rows.Add(new object[] { 
                    detalle.Producto.Id_Producto,
                    detalle.Producto.Marca, 
                    detalle.Producto.Modelo,
                    detalle.Producto.Descripcion,
                    detalle.Producto.Color,
                    detalle.Producto.Anio,
                    detalle.Producto.Precio_Vta,
                    detalle.Cantidad 
                });
                
            }

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

