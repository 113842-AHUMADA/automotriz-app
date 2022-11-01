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

        private void informaciónDeContactoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alumnos                                     Legajo\n\nAhumada Federico                    113842\nDe San Nicolas Macaño Indira 113013\nLuiten Lucas                               112862\nComisión: 1W3\nAño: 2022", "Información grupo 20", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}