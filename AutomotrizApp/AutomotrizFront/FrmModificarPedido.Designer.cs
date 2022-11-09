namespace AutomotrizFront
{
    partial class FrmModificarPedido
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
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.lblCarroceria = new System.Windows.Forms.Label();
            this.txtCarroceria = new System.Windows.Forms.TextBox();
            this.lblAnio = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.Label();
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
            this.cboProductos = new System.Windows.Forms.ComboBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.updCantidad = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtCalculo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(696, 13);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(89, 23);
            this.txtAnio.TabIndex = 38;
            // 
            // lblCarroceria
            // 
            this.lblCarroceria.AutoSize = true;
            this.lblCarroceria.Location = new System.Drawing.Point(419, 52);
            this.lblCarroceria.Name = "lblCarroceria";
            this.lblCarroceria.Size = new System.Drawing.Size(61, 15);
            this.lblCarroceria.TabIndex = 29;
            this.lblCarroceria.Text = "Carrocería";
            // 
            // txtCarroceria
            // 
            this.txtCarroceria.Location = new System.Drawing.Point(494, 46);
            this.txtCarroceria.Name = "txtCarroceria";
            this.txtCarroceria.Size = new System.Drawing.Size(111, 23);
            this.txtCarroceria.TabIndex = 30;
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(639, 16);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(29, 15);
            this.lblAnio.TabIndex = 37;
            this.lblAnio.Text = "Año";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(494, 81);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(111, 23);
            this.txtColor.TabIndex = 36;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(419, 84);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(36, 15);
            this.lblColor.TabIndex = 35;
            this.lblColor.Text = "Color";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(697, 46);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(88, 23);
            this.txtPrecio.TabIndex = 34;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(639, 52);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 15);
            this.lblPrecio.TabIndex = 33;
            this.lblPrecio.Text = "Precio";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(697, 81);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(51, 23);
            this.txtStock.TabIndex = 32;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(639, 84);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(36, 15);
            this.lblStock.TabIndex = 31;
            this.lblStock.Text = "Stock";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(494, 13);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(111, 23);
            this.txtMarca.TabIndex = 26;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(419, 16);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 15);
            this.lblMarca.TabIndex = 25;
            this.lblMarca.Text = "Marca";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "Fecha de entrega";
            // 
            // dtpFechaEntrega
            // 
            this.dtpFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEntrega.Location = new System.Drawing.Point(182, 136);
            this.dtpFechaEntrega.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpFechaEntrega.Name = "dtpFechaEntrega";
            this.dtpFechaEntrega.Size = new System.Drawing.Size(128, 23);
            this.dtpFechaEntrega.TabIndex = 3;
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(141, 13);
            this.txtEmpleado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(226, 23);
            this.txtEmpleado.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(65, 16);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 15);
            this.label14.TabIndex = 21;
            this.label14.Text = "Empleado";
            // 
            // txtTotal
            // 
            this.txtTotal.AutoSize = true;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotal.Location = new System.Drawing.Point(254, 442);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(113, 21);
            this.txtTotal.TabIndex = 18;
            this.txtTotal.Text = "TOTAL:            $";
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
            this.dgvDetalles.Location = new System.Drawing.Point(61, 184);
            this.dgvDetalles.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.RowHeadersWidth = 51;
            this.dgvDetalles.RowTemplate.Height = 24;
            this.dgvDetalles.Size = new System.Drawing.Size(724, 229);
            this.dgvDetalles.TabIndex = 6;
            this.dgvDetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalles_CellContentClick);
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
            this.col_cantidad.Width = 50;
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
            // 
            // cboProductos
            // 
            this.cboProductos.FormattingEnabled = true;
            this.cboProductos.Location = new System.Drawing.Point(141, 81);
            this.cboProductos.Margin = new System.Windows.Forms.Padding(2);
            this.cboProductos.Name = "cboProductos";
            this.cboProductos.Size = new System.Drawing.Size(226, 23);
            this.cboProductos.TabIndex = 2;
            this.cboProductos.Leave += new System.EventHandler(this.cboProductos_Leave);
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(65, 84);
            this.lblModelo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(48, 15);
            this.lblModelo.TabIndex = 11;
            this.lblModelo.Text = "Modelo";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(141, 46);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(226, 23);
            this.txtCliente.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 52);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cliente";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(629, 133);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(156, 28);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(629, 434);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(156, 36);
            this.btnActualizar.TabIndex = 39;
            this.btnActualizar.Text = "ACTUALIZAR PEDIDO";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // updCantidad
            // 
            this.updCantidad.Location = new System.Drawing.Point(436, 136);
            this.updCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updCantidad.Name = "updCantidad";
            this.updCantidad.Size = new System.Drawing.Size(120, 23);
            this.updCantidad.TabIndex = 4;
            this.updCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 41;
            this.label2.Text = "Cantidad";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(61, 434);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 36);
            this.btnCancelar.TabIndex = 42;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtCalculo
            // 
            this.txtCalculo.AutoSize = true;
            this.txtCalculo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCalculo.Location = new System.Drawing.Point(414, 438);
            this.txtCalculo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtCalculo.Name = "txtCalculo";
            this.txtCalculo.Size = new System.Drawing.Size(45, 28);
            this.txtCalculo.TabIndex = 43;
            this.txtCalculo.Text = "S/D";
            // 
            // FrmModificarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 494);
            this.Controls.Add(this.txtCalculo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.updCantidad);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dgvDetalles);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.dtpFechaEntrega);
            this.Controls.Add(this.lblCarroceria);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtCarroceria);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblAnio);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.cboProductos);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblStock);
            this.MaximumSize = new System.Drawing.Size(850, 533);
            this.MinimumSize = new System.Drawing.Size(850, 533);
            this.Name = "FrmModificarPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AUTOMOTRIZ APP - EDITAR";
            this.Load += new System.EventHandler(this.FrmModificarPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtAnio;
        private Label lblCarroceria;
        private TextBox txtCarroceria;
        private Label lblAnio;
        private TextBox txtColor;
        private Label lblColor;
        private TextBox txtPrecio;
        private Label lblPrecio;
        private TextBox txtStock;
        private Label lblStock;
        private TextBox txtMarca;
        private Label lblMarca;
        private Label label1;
        private DateTimePicker dtpFechaEntrega;
        private TextBox txtEmpleado;
        private Label label14;
        private Label txtTotal;
        private DataGridView dgvDetalles;
        private ComboBox cboProductos;
        private Label lblModelo;
        private TextBox txtCliente;
        private Label label6;
        private Button btnAgregar;
        private Button btnActualizar;
        private NumericUpDown updCantidad;
        private Label label2;
        private Button btnCancelar;
        private DataGridViewTextBoxColumn col_id;
        private DataGridViewTextBoxColumn col_marca;
        private DataGridViewTextBoxColumn col_modelo;
        private DataGridViewTextBoxColumn col_tipo;
        private DataGridViewTextBoxColumn col_color;
        private DataGridViewTextBoxColumn col_anio;
        private DataGridViewTextBoxColumn col_precio;
        private DataGridViewTextBoxColumn col_cantidad;
        private DataGridViewButtonColumn col_accion;
        private Label txtCalculo;
    }
}