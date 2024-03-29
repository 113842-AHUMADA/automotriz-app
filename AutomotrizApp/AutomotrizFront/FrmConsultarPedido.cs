﻿using AutomotrizApp.dominio;
using AutomotrizBack.datos;
using AutomotrizFront.Http;
using Microsoft.Reporting.WinForms;
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
    public partial class FrmConsultarPedido : Form
    {
        public FrmConsultarPedido()
        {
            InitializeComponent();
        }
        private void FrmConsultarPedido_Load(object sender, EventArgs e)
        {

        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private async Task CargarTodosGridAsync()
        {
            // crear un get documentos
            
        }

        private async Task CargarGridAsync()
        {
            List<Parametro> filtros = new List<Parametro>();
            filtros.Add(new Parametro("@fecha_desde", dtpDesde.Value.ToString("yyyy/MM/dd")));
            filtros.Add(new Parametro("@fecha_hasta", dtpHasta.Value.ToString("yyyy/MM/dd")));
            filtros.Add(new Parametro("@cliente", txtCliente.Text.ToString()));
            string filtrosJSON = JsonConvert.SerializeObject(filtros);
            var result = await ClienteSingleton.ObtenerInstancia().PostAsyncDefault("http://localhost:5008/api/Documento/consultar", filtrosJSON);
            
            List<Documento> lst = JsonConvert.DeserializeObject<List<Documento>>(result);
            foreach (Documento documento in lst)
            {
                dgvDocumentos.Rows.Add(new object[] 
                {documento.Id_Documento,"PEDIDO",documento.Vendedor, documento.Cliente,documento.Fecha_Documento.ToString("dd/MM/yyyy"),
                documento.Fecha_Entrega.ToString("dd/MM/yyyy")});
            }

        }

        private async void btnConsultar_Click(object sender, EventArgs e)
        {
            if(txtCliente.Text == "")
            {
                txtCliente.Text = " ";
                //MessageBox.Show("Ingresa un filtro en Cliente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //return;
            }
            dgvDocumentos.Rows.Clear();
            await CargarGridAsync();
        }


        private void dgvDocumentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDocumentos.CurrentCell.ColumnIndex == 6)
            {
                int id = int.Parse(dgvDocumentos.CurrentRow.Cells["col_id"].Value.ToString());
                //string cliente = dgvDocumentos.CurrentRow.Cells["col_cliente"].Value.ToString();
                //string vendedor = dgvDocumentos.CurrentRow.Cells["col_vendedor"].Value.ToString();
                //string fecha_entrega = dgvDocumentos.CurrentRow.Cells["col_fecha_entrega"].Value.ToString();
                new FrmDetalleDocumento(id).ShowDialog();
            }
        }


        private async Task<bool> BorrarDocumentoAsync(int id)
        {
            
            var result = await ClienteSingleton.ObtenerInstancia().DeleteAsync("http://localhost:5008/api/Documento/eliminar/" + id);
            bool respuesta = JsonConvert.DeserializeObject<bool>(result);
            return respuesta;
        }


        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDocumentos.RowCount == 0)
            {
                return;
            }
            if (MessageBox.Show("Seguro que desea quitar el presupuesto seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dgvDocumentos.CurrentRow != null)
                {
                    int id = int.Parse(dgvDocumentos.CurrentRow.Cells["col_id"].Value.ToString());
                    if (await BorrarDocumentoAsync(id))
                    {
                        MessageBox.Show("El pedido se eliminó exitosamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.btnConsultar_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("El pedido NO se eliminó exitosamente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvDocumentos.RowCount == 0)
            {
                return;
            }    
            int id = int.Parse(dgvDocumentos.CurrentRow.Cells["col_id"].Value.ToString());
            string cliente = dgvDocumentos.CurrentRow.Cells["col_cliente"].Value.ToString();
            new FrmModificarPedido(id,cliente).ShowDialog();
            this.btnConsultar_Click(null, null);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
