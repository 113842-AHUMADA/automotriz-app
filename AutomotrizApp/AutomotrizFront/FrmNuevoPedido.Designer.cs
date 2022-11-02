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
            this.grupo_Nuevo_Presupuesto = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnEliminarTodo = new System.Windows.Forms.Button();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.colIdProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAnio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioVta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboProductos = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
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
            this.grupo_Nuevo_Presupuesto.Controls.Add(this.label1);
            this.grupo_Nuevo_Presupuesto.Controls.Add(this.dtpFechaEntrega);
            this.grupo_Nuevo_Presupuesto.Controls.Add(this.txtEmpleado);
            this.grupo_Nuevo_Presupuesto.Controls.Add(this.label14);
            this.grupo_Nuevo_Presupuesto.Controls.Add(this.label13);
            this.grupo_Nuevo_Presupuesto.Controls.Add(this.txtTotal);
            this.grupo_Nuevo_Presupuesto.Controls.Add(this.label12);
            this.grupo_Nuevo_Presupuesto.Controls.Add(this.btnEliminarTodo);
            this.grupo_Nuevo_Presupuesto.Controls.Add(this.dgvDetalles);
            this.grupo_Nuevo_Presupuesto.Controls.Add(this.btnGrabar);
            this.grupo_Nuevo_Presupuesto.Controls.Add(this.btnEliminar);
            this.grupo_Nuevo_Presupuesto.Controls.Add(this.txtCantidad);
            this.grupo_Nuevo_Presupuesto.Controls.Add(this.label11);
            this.grupo_Nuevo_Presupuesto.Controls.Add(this.cboProductos);
            this.grupo_Nuevo_Presupuesto.Controls.Add(this.label10);
            this.grupo_Nuevo_Presupuesto.Controls.Add(this.txtCliente);
            this.grupo_Nuevo_Presupuesto.Controls.Add(this.label7);
            this.grupo_Nuevo_Presupuesto.Controls.Add(this.label6);
            this.grupo_Nuevo_Presupuesto.Controls.Add(this.btnAgregar);
            this.grupo_Nuevo_Presupuesto.Location = new System.Drawing.Point(8, 5);
            this.grupo_Nuevo_Presupuesto.Margin = new System.Windows.Forms.Padding(2);
            this.grupo_Nuevo_Presupuesto.Name = "grupo_Nuevo_Presupuesto";
            this.grupo_Nuevo_Presupuesto.Padding = new System.Windows.Forms.Padding(2);
            this.grupo_Nuevo_Presupuesto.Size = new System.Drawing.Size(1071, 362);
            this.grupo_Nuevo_Presupuesto.TabIndex = 4;
            this.grupo_Nuevo_Presupuesto.TabStop = false;
            this.grupo_Nuevo_Presupuesto.Text = "Nuevo Pedido";
            this.grupo_Nuevo_Presupuesto.Enter += new System.EventHandler(this.grupo_Nuevo_Presupuesto_Enter);
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
            this.dtpFechaEntrega.Location = new System.Drawing.Point(89, 267);
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
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(187, 156);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 15);
            this.label13.TabIndex = 20;
            this.label13.Text = "unidades";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(917, 255);
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
            // btnEliminarTodo
            // 
            this.btnEliminarTodo.Location = new System.Drawing.Point(436, 250);
            this.btnEliminarTodo.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarTodo.Name = "btnEliminarTodo";
            this.btnEliminarTodo.Size = new System.Drawing.Size(110, 28);
            this.btnEliminarTodo.TabIndex = 16;
            this.btnEliminarTodo.Text = "Eliminar todo";
            this.btnEliminarTodo.UseVisualStyleBackColor = true;
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.AllowUserToDeleteRows = false;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdProd,
            this.colCantidad,
            this.colModelo,
            this.colAnio,
            this.colMarca,
            this.colTipoProducto,
            this.colPrecioVta});
            this.dgvDetalles.Location = new System.Drawing.Point(350, 36);
            this.dgvDetalles.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.RowHeadersWidth = 51;
            this.dgvDetalles.RowTemplate.Height = 24;
            this.dgvDetalles.Size = new System.Drawing.Size(704, 209);
            this.dgvDetalles.TabIndex = 15;
            // 
            // colIdProd
            // 
            this.colIdProd.HeaderText = "ID";
            this.colIdProd.Name = "colIdProd";
            this.colIdProd.ReadOnly = true;
            this.colIdProd.Visible = false;
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cant.";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            this.colCantidad.Width = 50;
            // 
            // colModelo
            // 
            this.colModelo.HeaderText = "Modelo";
            this.colModelo.Name = "colModelo";
            this.colModelo.ReadOnly = true;
            // 
            // colAnio
            // 
            this.colAnio.HeaderText = "Año";
            this.colAnio.Name = "colAnio";
            this.colAnio.ReadOnly = true;
            // 
            // colMarca
            // 
            this.colMarca.HeaderText = "Marca";
            this.colMarca.Name = "colMarca";
            this.colMarca.ReadOnly = true;
            // 
            // colTipoProducto
            // 
            this.colTipoProducto.HeaderText = "Tipo";
            this.colTipoProducto.Name = "colTipoProducto";
            this.colTipoProducto.ReadOnly = true;
            // 
            // colPrecioVta
            // 
            this.colPrecioVta.HeaderText = "Precio Venta";
            this.colPrecioVta.Name = "colPrecioVta";
            this.colPrecioVta.ReadOnly = true;
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
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(350, 250);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(70, 28);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(89, 155);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(78, 23);
            this.txtCantidad.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 156);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 15);
            this.label11.TabIndex = 13;
            this.label11.Text = "Cantidad:";
            // 
            // cboProductos
            // 
            this.cboProductos.FormattingEnabled = true;
            this.cboProductos.Location = new System.Drawing.Point(89, 114);
            this.cboProductos.Margin = new System.Windows.Forms.Padding(2);
            this.cboProductos.Name = "cboProductos";
            this.cboProductos.Size = new System.Drawing.Size(226, 23);
            this.cboProductos.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 116);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "Producto:";
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
            this.btnAgregar.Location = new System.Drawing.Point(9, 189);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(70, 28);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // FrmNuevoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 450);
            this.Controls.Add(this.grupo_Nuevo_Presupuesto);
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
        private Label label13;
        private TextBox txtTotal;
        private Label label12;
        private Button btnEliminarTodo;
        private DataGridView dgvDetalles;
        private DataGridViewTextBoxColumn colIdProd;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewTextBoxColumn colModelo;
        private DataGridViewTextBoxColumn colAnio;
        private DataGridViewTextBoxColumn colMarca;
        private DataGridViewTextBoxColumn colTipoProducto;
        private DataGridViewTextBoxColumn colPrecioVta;
        private Button btnGrabar;
        private Button btnEliminar;
        private TextBox txtCantidad;
        private Label label11;
        private ComboBox cboProductos;
        private Label label10;
        private TextBox txtCliente;
        private Label label7;
        private Label label6;
        private Button btnAgregar;
    }
}