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

        private void CargarCombo()
        {
            HttpClient client = new HttpClient();
        }
    }
}
