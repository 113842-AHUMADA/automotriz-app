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
            var resultado = MessageBox.Show("�Est� seguro que desea salir del sistema?", "Salir", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes) 
                this.Dispose();
            else
            {
                return;
            }
                
        }

        private void informaci�nDeContactoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alumnos                                     Legajo\n\nAhumada Federico                    113842\nDe San Nicolas Maca�o Indira 113013\nLuiten Lucas                               112862\nComisi�n: 1W3\nA�o: 2022", "Informaci�n grupo 20", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void stockDeVehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporte stock_vehiculos = new FrmReporte();
            stock_vehiculos.ShowDialog();
        }
    }
}