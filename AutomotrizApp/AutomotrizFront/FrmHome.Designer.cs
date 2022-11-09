namespace AutomotrizFront
{
    partial class FrmHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.soporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeVehículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenDePedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaOrdenDePedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarOrdenDePedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockDeVehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasPorMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaciónDeContactoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.soporteToolStripMenuItem,
            this.ordenDePedidoToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(834, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem1});
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.salirToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem1.Text = "Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // soporteToolStripMenuItem
            // 
            this.soporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDeVehículoToolStripMenuItem});
            this.soporteToolStripMenuItem.Name = "soporteToolStripMenuItem";
            this.soporteToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.soporteToolStripMenuItem.Text = "Soporte";
            // 
            // altaDeVehículoToolStripMenuItem
            // 
            this.altaDeVehículoToolStripMenuItem.AutoToolTip = true;
            this.altaDeVehículoToolStripMenuItem.Name = "altaDeVehículoToolStripMenuItem";
            this.altaDeVehículoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.altaDeVehículoToolStripMenuItem.Text = "Alta de vehículo";
            this.altaDeVehículoToolStripMenuItem.ToolTipText = "Este menú sólo está disponible para supervisores";
            this.altaDeVehículoToolStripMenuItem.Click += new System.EventHandler(this.altaDeVehículoToolStripMenuItem_Click);
            // 
            // ordenDePedidoToolStripMenuItem
            // 
            this.ordenDePedidoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaOrdenDePedidoToolStripMenuItem,
            this.consultarOrdenDePedidoToolStripMenuItem});
            this.ordenDePedidoToolStripMenuItem.Name = "ordenDePedidoToolStripMenuItem";
            this.ordenDePedidoToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.ordenDePedidoToolStripMenuItem.Text = "Documentos";
            // 
            // nuevaOrdenDePedidoToolStripMenuItem
            // 
            this.nuevaOrdenDePedidoToolStripMenuItem.Name = "nuevaOrdenDePedidoToolStripMenuItem";
            this.nuevaOrdenDePedidoToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.nuevaOrdenDePedidoToolStripMenuItem.Text = "Nuevo Pedido";
            this.nuevaOrdenDePedidoToolStripMenuItem.Click += new System.EventHandler(this.nuevaOrdenDePedidoToolStripMenuItem_Click);
            // 
            // consultarOrdenDePedidoToolStripMenuItem
            // 
            this.consultarOrdenDePedidoToolStripMenuItem.Name = "consultarOrdenDePedidoToolStripMenuItem";
            this.consultarOrdenDePedidoToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.consultarOrdenDePedidoToolStripMenuItem.Text = "Consultar Pedidos";
            this.consultarOrdenDePedidoToolStripMenuItem.Click += new System.EventHandler(this.consultarOrdenDePedidoToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockDeVehiculosToolStripMenuItem,
            this.ventasPorMarcaToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // stockDeVehiculosToolStripMenuItem
            // 
            this.stockDeVehiculosToolStripMenuItem.Name = "stockDeVehiculosToolStripMenuItem";
            this.stockDeVehiculosToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.stockDeVehiculosToolStripMenuItem.Text = "Stock de Vehiculos";
            this.stockDeVehiculosToolStripMenuItem.Click += new System.EventHandler(this.stockDeVehiculosToolStripMenuItem_Click);
            // 
            // ventasPorMarcaToolStripMenuItem
            // 
            this.ventasPorMarcaToolStripMenuItem.Name = "ventasPorMarcaToolStripMenuItem";
            this.ventasPorMarcaToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.ventasPorMarcaToolStripMenuItem.Text = "Ventas por Marca";
            this.ventasPorMarcaToolStripMenuItem.Click += new System.EventHandler(this.ventasPorMarcaToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informaciónDeContactoToolStripMenuItem});
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            // 
            // informaciónDeContactoToolStripMenuItem
            // 
            this.informaciónDeContactoToolStripMenuItem.Name = "informaciónDeContactoToolStripMenuItem";
            this.informaciónDeContactoToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.informaciónDeContactoToolStripMenuItem.Text = "Información de contacto";
            this.informaciónDeContactoToolStripMenuItem.Click += new System.EventHandler(this.informaciónDeContactoToolStripMenuItem_Click);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 494);
            this.Controls.Add(this.menuStrip1);
            this.MaximumSize = new System.Drawing.Size(850, 533);
            this.MinimumSize = new System.Drawing.Size(850, 533);
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AUTOMOTRIZ APP";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem1;
        private ToolStripMenuItem ordenDePedidoToolStripMenuItem;
        private ToolStripMenuItem nuevaOrdenDePedidoToolStripMenuItem;
        private ToolStripMenuItem consultarOrdenDePedidoToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private ToolStripMenuItem informaciónDeContactoToolStripMenuItem;
        private ToolStripMenuItem stockDeVehiculosToolStripMenuItem;
        private ToolStripMenuItem soporteToolStripMenuItem;
        private ToolStripMenuItem altaDeVehículoToolStripMenuItem;
        private ToolStripMenuItem ventasPorMarcaToolStripMenuItem;
    }
}