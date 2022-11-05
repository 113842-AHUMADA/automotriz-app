using AutomotrizApp.dominio;
using AutomotrizFront.Http;
//using AutomotrizFront.Reportes.DSListadoTableAdapters;
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
    public partial class FrmReporte : Form
    {
        public FrmReporte()
        {
            InitializeComponent();
        }

        private void FrmReporte_Load(object sender, EventArgs e)
        {
             //reportViewer1.LocalReport.ReportEmbeddedResource = "AutomotrizFront.Reportes.ListadoProductos.rdlc";
            CargarReporteAsync();
            
        }

        private async Task CargarReporteAsync()
        {
            var result = await ClienteSingleton.ObtenerInstancia().GetAsync("http://localhost:5008/api/Producto/consultar");

            DataTable dt = JsonConvert.DeserializeObject<DataTable>(result);
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt));
            reportViewer1.RefreshReport();
        }




    }
}
