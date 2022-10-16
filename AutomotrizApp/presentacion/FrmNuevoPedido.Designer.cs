namespace AutomotrizApp.presentacion
{
    partial class frmNuevoPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNuevoPedido));
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
            this.col_id_prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_anio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_precio_vta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_accion = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.grupo_Nuevo_Presupuesto.Location = new System.Drawing.Point(11, 11);
            this.grupo_Nuevo_Presupuesto.Margin = new System.Windows.Forms.Padding(2);
            this.grupo_Nuevo_Presupuesto.Name = "grupo_Nuevo_Presupuesto";
            this.grupo_Nuevo_Presupuesto.Padding = new System.Windows.Forms.Padding(2);
            this.grupo_Nuevo_Presupuesto.Size = new System.Drawing.Size(918, 314);
            this.grupo_Nuevo_Presupuesto.TabIndex = 4;
            this.grupo_Nuevo_Presupuesto.TabStop = false;
            this.grupo_Nuevo_Presupuesto.Text = "Nuevo Pedido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 209);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Fecha de entrega:";
            // 
            // dtpFechaEntrega
            // 
            this.dtpFechaEntrega.Location = new System.Drawing.Point(76, 231);
            this.dtpFechaEntrega.Name = "dtpFechaEntrega";
            this.dtpFechaEntrega.Size = new System.Drawing.Size(194, 20);
            this.dtpFechaEntrega.TabIndex = 23;
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(76, 31);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(194, 20);
            this.txtEmpleado.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Empleado:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(161, 136);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "unidades";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(786, 221);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(118, 20);
            this.txtTotal.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(691, 224);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "TOTAL:            $";
            // 
            // btnEliminarTodo
            // 
            this.btnEliminarTodo.Location = new System.Drawing.Point(374, 217);
            this.btnEliminarTodo.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarTodo.Name = "btnEliminarTodo";
            this.btnEliminarTodo.Size = new System.Drawing.Size(94, 24);
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
            this.col_id_prod,
            this.col_marca,
            this.col_descripcion,
            this.col_anio,
            this.col_cantidad,
            this.col_precio_vta,
            this.col_accion});
            this.dgvDetalles.Location = new System.Drawing.Point(300, 31);
            this.dgvDetalles.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.RowHeadersWidth = 51;
            this.dgvDetalles.RowTemplate.Height = 24;
            this.dgvDetalles.Size = new System.Drawing.Size(603, 181);
            this.dgvDetalles.TabIndex = 15;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(797, 271);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(107, 30);
            this.btnGrabar.TabIndex = 0;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(300, 217);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(60, 24);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(76, 134);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(67, 20);
            this.txtCantidad.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 136);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Cantidad:";
            // 
            // cboProductos
            // 
            this.cboProductos.FormattingEnabled = true;
            this.cboProductos.Location = new System.Drawing.Point(76, 99);
            this.cboProductos.Margin = new System.Windows.Forms.Padding(2);
            this.cboProductos.Name = "cboProductos";
            this.cboProductos.Size = new System.Drawing.Size(194, 21);
            this.cboProductos.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 101);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Producto:";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(76, 65);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(194, 20);
            this.txtCliente.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 59);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 70);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cliente:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(8, 164);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(60, 24);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // col_id_prod
            // 
            this.col_id_prod.HeaderText = "ID";
            this.col_id_prod.Name = "col_id_prod";
            this.col_id_prod.ReadOnly = true;
            this.col_id_prod.Visible = false;
            // 
            // col_marca
            // 
            this.col_marca.HeaderText = "MARCA";
            this.col_marca.Name = "col_marca";
            this.col_marca.ReadOnly = true;
            this.col_marca.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // col_descripcion
            // 
            this.col_descripcion.HeaderText = "DESCRIPCION";
            this.col_descripcion.Name = "col_descripcion";
            this.col_descripcion.ReadOnly = true;
            this.col_descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_descripcion.Width = 150;
            // 
            // col_anio
            // 
            this.col_anio.HeaderText = "AÑO";
            this.col_anio.Name = "col_anio";
            this.col_anio.ReadOnly = true;
            this.col_anio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_anio.Width = 65;
            // 
            // col_cantidad
            // 
            this.col_cantidad.HeaderText = "CANT.";
            this.col_cantidad.Name = "col_cantidad";
            this.col_cantidad.ReadOnly = true;
            this.col_cantidad.Width = 50;
            // 
            // col_precio_vta
            // 
            this.col_precio_vta.HeaderText = "U$D";
            this.col_precio_vta.Name = "col_precio_vta";
            this.col_precio_vta.ReadOnly = true;
            // 
            // col_accion
            // 
            this.col_accion.HeaderText = "ACCION";
            this.col_accion.Name = "col_accion";
            this.col_accion.ReadOnly = true;
            this.col_accion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // frmNuevoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 339);
            this.Controls.Add(this.grupo_Nuevo_Presupuesto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(956, 378);
            this.MinimumSize = new System.Drawing.Size(956, 378);
            this.Name = "frmNuevoPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AUTOMOTRIZ APP ";
            this.grupo_Nuevo_Presupuesto.ResumeLayout(false);
            this.grupo_Nuevo_Presupuesto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grupo_Nuevo_Presupuesto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrega;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnEliminarTodo;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboProductos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id_prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_anio;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_precio_vta;
        private System.Windows.Forms.DataGridViewButtonColumn col_accion;
    }
}