using AutomotrizBack.datos;

namespace AutomotrizFront
{
    public partial class FrmHome : Form
    {
        private LoginDTO usuario_logueado;
        public FrmHome(LoginDTO usuario)
        {
            this.usuario_logueado = usuario;
            
            InitializeComponent();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            this.Text = this.Text +" Usuario/a: "+ usuario_logueado.nombreApellido;
            if (usuario_logueado.privilegio != "administrador")
            {
                altaDeVehículoToolStripMenuItem.Enabled = false;
                altaDeVehículoToolStripMenuItem.ToolTipText = "Este menú solo está disponible para supervisores";
            }
        }

        private void nuevaOrdenDePedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevoPedido nuevoPedido = new FrmNuevoPedido(usuario_logueado);
            nuevoPedido.ShowDialog();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("¿Está seguro que desea salir del sistema?", "Salir", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes) 
                this.Dispose();
            else
            {
                return;
            }
                
        }

        private void informaciónDeContactoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alumnos                                     Legajo\n\nAhumada Federico                    113842\nDe San Nicolas Macaño Indira 113013\nLuiten Lucas                               112862\nComisión: 1W3\nAño: 2022", "Información grupo 20", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void stockDeVehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporteListado stock_vehiculos = new FrmReporteListado();
            stock_vehiculos.ShowDialog();
        }

        private void altaDeVehículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVehiculo alta_vehiculo = new frmVehiculo();
            alta_vehiculo.ShowDialog();
        }
    }
}