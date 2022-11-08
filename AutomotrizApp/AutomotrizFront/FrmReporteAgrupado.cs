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
    public partial class FrmReporteAgrupado : Form
    {
        public FrmReporteAgrupado()
        {
            InitializeComponent();
        }

        private void FrmReporteAgrupado_Load(object sender, EventArgs e)
        {
            
        }

        private async Task CargarReporteAsync()
        {
            List<Parametro> filtros = new List<Parametro>();
            filtros.Add(new Parametro("@fecha_desde", dtpFechaDesde.Value.ToString("yyyy/MM/dd")));
            filtros.Add(new Parametro("@fecha_hasta", dtpFechaHasta.Value.ToString("yyyy/MM/dd")));
            string filtrosJSON = JsonConvert.SerializeObject(filtros);
            var result = await ClienteSingleton.ObtenerInstancia().PostAsyncDefault("http://localhost:5008/api/Producto/reporte/agrupado", filtrosJSON);

            DataTable dt = JsonConvert.DeserializeObject<DataTable>(result);
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet2", dt));
            
        }

        
        private async void btnGenerar_Click(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            await CargarReporteAsync();
            reportViewer1.RefreshReport();

        }
    }
}
