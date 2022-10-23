using AutomotrizApp.dominio;
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
            HttpClient client = new HttpClient();
            var result = await client.GetAsync("http://localhost:5008/api/Pedido/productos");

            string body = await result.Content.ReadAsStringAsync();
            List<Producto> lst = JsonConvert.DeserializeObject<List<Producto>>(body);

            cboProductos.DataSource = lst;
            cboProductos.DisplayMember = "Descripcion";
            cboProductos.ValueMember = "Id_producto";
        }


    }
}
