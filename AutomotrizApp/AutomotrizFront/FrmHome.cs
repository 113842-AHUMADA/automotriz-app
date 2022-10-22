namespace AutomotrizFront
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {

        }

        private void nuevaOrdenDePedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevoPedido nuevoPedido = new FrmNuevoPedido();
            nuevoPedido.ShowDialog();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}