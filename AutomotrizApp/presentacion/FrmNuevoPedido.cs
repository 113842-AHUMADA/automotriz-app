using AutomotrizApp.dominio;
using AutomotrizApp.servicios;
using AutomotrizApp.servicios.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomotrizApp.presentacion
{
    public partial class frmNuevoPedido : Form
    {
        private IServicio oServicio;
        private FabricaServicio oFabrica;
        private Pedido pedido;
        public frmNuevoPedido()
        {
            InitializeComponent();
            
            oFabrica = new FabricaServicioImp();
            oServicio = oFabrica.CrearServicio();
            pedido = new Pedido();
            
        }

        private void frmNuevoPedido_Load(object sender, EventArgs e)
        {
            cboProductos.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDescripcion.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEmpleado.SelectedIndex = -1;
            cboCliente.SelectedIndex = -1;
            CargarCboProductos();
            Limpiar();
        }

        private void Limpiar()
        {
            cboDescripcion.SelectedIndex = -1;
            cboProductos.SelectedIndex = -1;
            
            
        }

        private void CargarCboProductos()
        {
            cboProductos.DataSource = oServicio.ObtenerProductos();
            cboProductos.DisplayMember = "marca";
            cboProductos.ValueMember = "id_producto";
            
        }
    }
}
