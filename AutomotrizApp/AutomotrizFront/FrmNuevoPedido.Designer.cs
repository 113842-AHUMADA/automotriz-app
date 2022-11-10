namespace AutomotrizFront
{
    partial class FrmNuevoPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNuevoPedido));
            this.grupo_Nuevo_Presupuesto = new System.Windows.Forms.GroupBox();
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
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.colIdProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAnio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioVta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.cboProductos = new System.Windows.Forms.ComboBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.grupo_Nuevo_Presupuesto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // grupo_Nuevo_Presupuesto
            // 
            this.grupo_Nuevo_Presupuesto.Controls.Add(this.txtAnio);
            this.grupo_Nuevo_Presupuesto.Controls.Add(this.lblCarroceria);
            this.grupo_Nuevo_Presupuesto.Controls.Add(this.txtCarroceria);
            this.grupo_Nuevo_Presupuesto.Controls.Add(this.lblAnio);
            this.grupo_Nuevo_Presupuesto.Controls.Add(this.txtColor);
            this.grupo_Nuevo_Presupuesto.Controls.Add(this.lblColor);
            this.grupo_Nuevo_Presupuesto.Controls.Add(this.txtPrecio);
            this.grupo_Nuevo_Presupuesto.Controls.Add(this.lblPrecio);
            this.grupo_Nuevo_Presupuesto.Controls.Add(this.txtStock);
            this.grupo_Nuevo_Presupuesto.Controls.Add(this.lblStock);
            this.grupo_Nuevo_Presupuesto.Controls.Add(this.txtMarca);
            this.grupo_Nuevo_Presupuesto.Controls.Add(this.lblMarca);
            this.grupo_Nuevo_Presupuesto.Controls.Add(this.label1);
            this.grupo_Nuevo_Presupuesto.Controls.Add(this.dtpFechaEntrega);
            this.grupo_Nuevo_Presupuesto.Controls.Add(this.txtEmpleado);
            this.grupo_Nuevo_Presupuesto.Controls.Add(this.label14);
            this.grupo_Nuevo_Presupuesto.Controls.Add(this.txtTotal);
            this.grupo_Nuevo_Presupuesto.Controls.Add(this.label12);
            this.grupo_Nuevo_Presupuesto.Controls.Add(this.dgvDetalles);
            this.grupo_Nuevo_Presupuesto.Controls.Add(this.btnGrabar);
            this.grupo_Nuevo_Presupuesto.Controls.Add(this.cboProductos);
            this.grupo_Nuevo_Presupuesto.Controls.Add(this.lblModelo);
            this.grupo_Nuevo_Presupuesto.Controls.Add(this.txtCliente);
            this.grupo_Nuevo_Presupuesto.Controls.Add(this.label7);
            this.grupo_Nuevo_Presupuesto.Controls.Add(this.label6);
            this.grupo_Nuevo_Presupuesto.Controls.Add(this.btnAgregar);
            this.grupo_Nuevo_Presupuesto.Location = new System.Drawing.Point(8, 5);
            this.grupo_Nuevo_Presupuesto.Margin = new System.Windows.Forms.Padding(2);
            this.grupo_Nuevo_Presupuesto.Name = "grupo_Nuevo_Presupuesto";
            this.grupo_Nuevo_Presupuesto.Padding = new System.Windows.Forms.Padding(2);
            this.grupo_Nuevo_Presupuesto.Size = new System.Drawing.Size(1082, 362);
            this.grupo_Nuevo_Presupuesto.TabIndex = 4;
            this.grupo_Nuevo_Presupuesto.TabStop = false;
            this.grupo_Nuevo_Presupuesto.Text = "Nuevo Pedido";
            this.grupo_Nuevo_Presupuesto.Enter += new System.EventHandler(this.grupo_Nuevo_Presupuesto_Enter);
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(264, 150);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(51, 23);
            this.txtAnio.TabIndex = 38;
            // 
            // lblCarroceria
            // 
            this.lblCarroceria.AutoSize = true;
            this.lblCarroceria.Location = new System.Drawing.Point(5, 182);
            this.lblCarroceria.Name = "lblCarroceria";
            this.lblCarroceria.Size = new System.Drawing.Size(61, 15);
            this.lblCarroceria.TabIndex = 29;
            this.lblCarroceria.Text = "Carrocería";
            // 
            // txtCarroceria
            // 
            this.txtCarroceria.Location = new System.Drawing.Point(72, 179);
            this.txtCarroceria.Name = "txtCarroceria";
            this.txtCarroceria.Size = new System.Drawing.Size(98, 23);
            this.txtCarroceria.TabIndex = 30;
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(222, 155);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(29, 15);
            this.lblAnio.TabIndex = 37;
            this.lblAnio.Text = "Año";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(72, 208);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(98, 23);
            this.txtColor.TabIndex = 36;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(5, 211);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(36, 15);
            this.lblColor.TabIndex = 35;
            this.lblColor.Text = "Color";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(265, 179);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(50, 23);
            this.txtPrecio.TabIndex = 34;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(211, 182);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 15);
            this.lblPrecio.TabIndex = 33;
            this.lblPrecio.Text = "Precio";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(264, 205);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(51, 23);
            this.txtStock.TabIndex = 32;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(222, 208);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(36, 15);
            this.lblStock.TabIndex = 31;
            this.lblStock.Text = "Stock";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(59, 150);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(111, 23);
            this.txtMarca.TabIndex = 26;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(5, 153);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 15);
            this.lblMarca.TabIndex = 25;
            this.lblMarca.Text = "Marca";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 240);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "Fecha de entrega:";
            // 
            // dtpFechaEntrega
            // 
            this.dtpFechaEntrega.Location = new System.Drawing.Point(9, 270);
            this.dtpFechaEntrega.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpFechaEntrega.Name = "dtpFechaEntrega";
            this.dtpFechaEntrega.Size = new System.Drawing.Size(226, 23);
            this.dtpFechaEntrega.TabIndex = 23;
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(89, 36);
            this.txtEmpleado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(226, 23);
            this.txtEmpleado.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 42);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 15);
            this.label14.TabIndex = 21;
            this.label14.Text = "Empleado:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(893, 254);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(137, 23);
            this.txtTotal.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(805, 257);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 15);
            this.label12.TabIndex = 18;
            this.label12.Text = "TOTAL:            $";
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.AllowUserToDeleteRows = false;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdProd,
            this.colMarca,
            this.colModelo,
            this.colTipoProducto,
            this.colColor,
            this.colAnio,
            this.colPrecioVta,
            this.colCantidad,
            this.colAcciones});
            this.dgvDetalles.Location = new System.Drawing.Point(350, 36);
            this.dgvDetalles.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.RowHeadersWidth = 51;
            this.dgvDetalles.RowTemplate.Height = 24;
            this.dgvDetalles.Size = new System.Drawing.Size(716, 209);
            this.dgvDetalles.TabIndex = 15;
            this.dgvDetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalles_CellContentClick);
            // 
            // colIdProd
            // 
            this.colIdProd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colIdProd.HeaderText = "ID";
            this.colIdProd.Name = "colIdProd";
            this.colIdProd.ReadOnly = true;
            this.colIdProd.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colIdProd.Visible = false;
            // 
            // colMarca
            // 
            this.colMarca.HeaderText = "Marca";
            this.colMarca.Name = "colMarca";
            this.colMarca.ReadOnly = true;
            // 
            // colModelo
            // 
            this.colModelo.HeaderText = "Modelo";
            this.colModelo.Name = "colModelo";
            this.colModelo.ReadOnly = true;
            // 
            // colTipoProducto
            // 
            this.colTipoProducto.HeaderText = "Tipo";
            this.colTipoProducto.MinimumWidth = 50;
            this.colTipoProducto.Name = "colTipoProducto";
            this.colTipoProducto.ReadOnly = true;
            // 
            // colColor
            // 
            this.colColor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colColor.HeaderText = "Color";
            this.colColor.Name = "colColor";
            this.colColor.ReadOnly = true;
            this.colColor.Width = 61;
            // 
            // colAnio
            // 
            this.colAnio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colAnio.HeaderText = "Año";
            this.colAnio.MinimumWidth = 15;
            this.colAnio.Name = "colAnio";
            this.colAnio.ReadOnly = true;
            this.colAnio.Width = 54;
            // 
            // colPrecioVta
            // 
            this.colPrecioVta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colPrecioVta.HeaderText = "Precio Venta";
            this.colPrecioVta.Name = "colPrecioVta";
            this.colPrecioVta.ReadOnly = true;
            this.colPrecioVta.Width = 97;
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cant.";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            this.colCantidad.Width = 50;
            // 
            // colAcciones
            // 
            this.colAcciones.HeaderText = "Acciones";
            this.colAcciones.Name = "colAcciones";
            this.colAcciones.ReadOnly = true;
            this.colAcciones.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colAcciones.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colAcciones.Text = "Quitar";
            this.colAcciones.UseColumnTextForButtonValue = true;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(930, 313);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(125, 35);
            this.btnGrabar.TabIndex = 0;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // cboProductos
            // 
            this.cboProductos.FormattingEnabled = true;
            this.cboProductos.Location = new System.Drawing.Point(89, 114);
            this.cboProductos.Margin = new System.Windows.Forms.Padding(2);
            this.cboProductos.Name = "cboProductos";
            this.cboProductos.Size = new System.Drawing.Size(226, 23);
            this.cboProductos.TabIndex = 12;
            this.cboProductos.Leave += new System.EventHandler(this.cboProductos_Leave);
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(5, 116);
            this.lblModelo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(48, 15);
            this.lblModelo.TabIndex = 11;
            this.lblModelo.Text = "Modelo";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(89, 75);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(226, 23);
            this.txtCliente.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 67);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 15);
            this.label7.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 80);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cliente:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(267, 270);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(70, 28);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // FrmNuevoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 450);
            this.Controls.Add(this.grupo_Nuevo_Presupuesto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmNuevoPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AUTOMOTRIZ APP";
            this.Load += new System.EventHandler(this.FrmNuevoPedido_Load);
            this.grupo_Nuevo_Presupuesto.ResumeLayout(false);
            this.grupo_Nuevo_Presupuesto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grupo_Nuevo_Presupuesto;
        private Label label1;
        private DateTimePicker dtpFechaEntrega;
        private TextBox txtEmpleado;
        private Label label14;
        private TextBox txtTotal;
        private Label label12;
        private DataGridView dgvDetalles;
        private Button btnGrabar;
        private ComboBox cboProductos;
        private TextBox txtCliente;
        private Label label7;
        private Label label6;
        private Button btnAgregar;
        private TextBox txtMarca;
        private Label lblMarca;
        private Label lblModelo;
        private TextBox txtStock;
        private Label lblStock;
        private TextBox txtCarroceria;
        private Label lblCarroceria;
        private TextBox txtAnio;
        private Label lblAnio;
        private TextBox txtColor;
        private Label lblColor;
        private TextBox txtPrecio;
        private Label lblPrecio;
        private DataGridViewTextBoxColumn colIdProd;
        private DataGridViewTextBoxColumn colMarca;
        private DataGridViewTextBoxColumn colModelo;
        private DataGridViewTextBoxColumn colTipoProducto;
        private DataGridViewTextBoxColumn colColor;
        private DataGridViewTextBoxColumn colAnio;
        private DataGridViewTextBoxColumn colPrecioVta;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewButtonColumn colAcciones;
    }
}