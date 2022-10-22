using AutomotrizApp.dominio;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomotrizFront
{
    public partial class FrmNuevoPedido : Form
    {

        HttpClient client = new HttpClient();

        //http://localhost:5008/api/Pedido/pedidos

        public FrmNuevoPedido()
        {
            InitializeComponent();
        }

        private async void FrmNuevoPedido_Load(object sender, EventArgs e)
        {
            await CargarComboAsync();
        }

        private async Task CargarComboAsync()
        {
            string url = "http://localhost:5008/api/Pedido/productos";
            var result = await client.GetAsync(url);

            string body = await result.Content.ReadAsStringAsync();
            List<Producto> lst = JsonConvert.DeserializeObject<List<Producto>>(body);


            cboProductos.DataSource = lst;
            cboProductos.DisplayMember = "Marca"+"Descripcion";
            cboProductos.ValueMember = "Id_producto";
        }
    }
}
