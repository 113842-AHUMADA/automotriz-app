namespace AutomotrizFront
{
    partial class FrmDetalleDocumento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_anio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_accion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.txtFechaEntrega = new System.Windows.Forms.TextBox();
            this.txtFechaDocumento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.AllowUserToDeleteRows = false;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id,
            this.col_marca,
            this.col_modelo,
            this.col_tipo,
            this.col_color,
            this.col_anio,
            this.col_precio,
            this.col_cantidad,
            this.col_accion});
            this.dgvDetalles.Location = new System.Drawing.Point(81, 156);
            this.dgvDetalles.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.RowHeadersWidth = 51;
            this.dgvDetalles.RowTemplate.Height = 24;
            this.dgvDetalles.Size = new System.Drawing.Size(673, 229);
            this.dgvDetalles.TabIndex = 0;
            // 
            // col_id
            // 
            this.col_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.col_id.HeaderText = "ID";
            this.col_id.Name = "col_id";
            this.col_id.ReadOnly = true;
            this.col_id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_id.Visible = false;
            // 
            // col_marca
            // 
            this.col_marca.HeaderText = "MARCA";
            this.col_marca.Name = "col_marca";
            this.col_marca.ReadOnly = true;
            // 
            // col_modelo
            // 
            this.col_modelo.HeaderText = "MODELO";
            this.col_modelo.Name = "col_modelo";
            this.col_modelo.ReadOnly = true;
            // 
            // col_tipo
            // 
            this.col_tipo.HeaderText = "TIPO";
            this.col_tipo.MinimumWidth = 50;
            this.col_tipo.Name = "col_tipo";
            this.col_tipo.ReadOnly = true;
            // 
            // col_color
            // 
            this.col_color.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.col_color.HeaderText = "COLOR";
            this.col_color.Name = "col_color";
            this.col_color.ReadOnly = true;
            this.col_color.Width = 71;
            // 
            // col_anio
            // 
            this.col_anio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.col_anio.HeaderText = "AÑO";
            this.col_anio.MinimumWidth = 15;
            this.col_anio.Name = "col_anio";
            this.col_anio.ReadOnly = true;
            this.col_anio.Width = 58;
            // 
            // col_precio
            // 
            this.col_precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.col_precio.HeaderText = "PRECIO U$D";
            this.col_precio.Name = "col_precio";
            this.col_precio.ReadOnly = true;
            this.col_precio.Width = 97;
            // 
            // col_cantidad
            // 
            this.col_cantidad.HeaderText = "CANT.";
            this.col_cantidad.Name = "col_cantidad";
            this.col_cantidad.ReadOnly = true;
            // 
            // col_accion
            // 
            this.col_accion.HeaderText = "ACCION";
            this.col_accion.Name = "col_accion";
            this.col_accion.ReadOnly = true;
            this.col_accion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_accion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_accion.Text = "Quitar";
            this.col_accion.UseColumnTextForButtonValue = true;
            this.col_accion.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(500, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "Fecha de entrega";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(257, 28);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 15);
            this.label14.TabIndex = 27;
            this.label14.Text = "Empleado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(526, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 25;
            this.label6.Text = "Cliente";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(435, 46);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(226, 23);
            this.txtCliente.TabIndex = 26;
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(174, 46);
            this.txtEmpleado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(226, 23);
            this.txtEmpleado.TabIndex = 28;
            // 
            // txtFechaEntrega
            // 
            this.txtFechaEntrega.Location = new System.Drawing.Point(435, 107);
            this.txtFechaEntrega.Margin = new System.Windows.Forms.Padding(2);
            this.txtFechaEntrega.Name = "txtFechaEntrega";
            this.txtFechaEntrega.Size = new System.Drawing.Size(226, 23);
            this.txtFechaEntrega.TabIndex = 30;
            // 
            // txtFechaDocumento
            // 
            this.txtFechaDocumento.Location = new System.Drawing.Point(174, 107);
            this.txtFechaDocumento.Margin = new System.Windows.Forms.Padding(2);
            this.txtFechaDocumento.Name = "txtFechaDocumento";
            this.txtFechaDocumento.Size = new System.Drawing.Size(226, 23);
            this.txtFechaDocumento.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "Fecha de Emision";
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVolver.Location = new System.Drawing.Point(353, 420);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(121, 45);
            this.btnVolver.TabIndex = 33;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FrmDetalleDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 494);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txtFechaDocumento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFechaEntrega);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.dgvDetalles);
            this.MaximumSize = new System.Drawing.Size(850, 533);
            this.MinimumSize = new System.Drawing.Size(850, 533);
            this.Name = "FrmDetalleDocumento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AUTOMOTRIZ APP - VER DETALLE ";
            this.Load += new System.EventHandler(this.FrmDetalleDocumento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvDetalles;
        private DataGridViewTextBoxColumn col_id;
        private DataGridViewTextBoxColumn col_marca;
        private DataGridViewTextBoxColumn col_modelo;
        private DataGridViewTextBoxColumn col_tipo;
        private DataGridViewTextBoxColumn col_color;
        private DataGridViewTextBoxColumn col_anio;
        private DataGridViewTextBoxColumn col_precio;
        private DataGridViewTextBoxColumn col_cantidad;
        private DataGridViewButtonColumn col_accion;
        private Label label1;
        private Label label14;
        private Label label6;
        private TextBox txtCliente;
        private TextBox txtEmpleado;
        private TextBox txtFechaEntrega;
        private TextBox txtFechaDocumento;
        private Label label2;
        private Button btnVolver;
    }
}