namespace FactorySys
{
    partial class frmMAIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMAIN));
            this.lblUSUARIO = new System.Windows.Forms.LinkLabel();
            this.Gestion = new System.Windows.Forms.ToolStripMenuItem();
            this.Proveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.Clientes = new System.Windows.Forms.ToolStripMenuItem();
            this.Insumos = new System.Windows.Forms.ToolStripMenuItem();
            this.Productos = new System.Windows.Forms.ToolStripMenuItem();
            this.Almacen = new System.Windows.Forms.ToolStripMenuItem();
            this.OrdenCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.Remito = new System.Windows.Forms.ToolStripMenuItem();
            this.Stock = new System.Windows.Forms.ToolStripMenuItem();
            this.Seguridad = new System.Windows.Forms.ToolStripMenuItem();
            this.Usuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.Grupos = new System.Windows.Forms.ToolStripMenuItem();
            this.CopiaSeguridad = new System.Windows.Forms.ToolStripMenuItem();
            this.AuTarea = new System.Windows.Forms.ToolStripMenuItem();
            this.AuLoginOut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.produccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Pedido = new System.Windows.Forms.ToolStripMenuItem();
            this.OrdenF = new System.Windows.Forms.ToolStripMenuItem();
            this.Fabrica = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCERRAR = new System.Windows.Forms.Button();
            this.btnSALIR = new System.Windows.Forms.Button();
            this.lbl4 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMANUAL = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUSUARIO
            // 
            this.lblUSUARIO.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblUSUARIO.AutoSize = true;
            this.lblUSUARIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUSUARIO.LinkColor = System.Drawing.Color.Black;
            this.lblUSUARIO.Location = new System.Drawing.Point(8, 387);
            this.lblUSUARIO.Name = "lblUSUARIO";
            this.lblUSUARIO.Size = new System.Drawing.Size(0, 17);
            this.lblUSUARIO.TabIndex = 7;
            // 
            // Gestion
            // 
            this.Gestion.BackColor = System.Drawing.Color.Transparent;
            this.Gestion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Proveedores,
            this.Clientes,
            this.Insumos,
            this.Productos});
            this.Gestion.Name = "Gestion";
            this.Gestion.Size = new System.Drawing.Size(59, 20);
            this.Gestion.Text = "Gestion";
            // 
            // Proveedores
            // 
            this.Proveedores.BackColor = System.Drawing.SystemColors.Control;
            this.Proveedores.Image = global::FactorySys.Properties.Resources.app_chart;
            this.Proveedores.Name = "Proveedores";
            this.Proveedores.Size = new System.Drawing.Size(184, 26);
            this.Proveedores.Text = "Proveedores";
            this.Proveedores.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // Clientes
            // 
            this.Clientes.Image = global::FactorySys.Properties.Resources.app_preferences;
            this.Clientes.Name = "Clientes";
            this.Clientes.Size = new System.Drawing.Size(184, 26);
            this.Clientes.Text = "Clientes";
            this.Clientes.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // Insumos
            // 
            this.Insumos.BackColor = System.Drawing.SystemColors.Control;
            this.Insumos.Image = global::FactorySys.Properties.Resources.app_large_icons;
            this.Insumos.Name = "Insumos";
            this.Insumos.Size = new System.Drawing.Size(184, 26);
            this.Insumos.Text = "Insumos";
            this.Insumos.Click += new System.EventHandler(this.insumosToolStripMenuItem_Click);
            // 
            // Productos
            // 
            this.Productos.Image = global::FactorySys.Properties.Resources.app_options;
            this.Productos.Name = "Productos";
            this.Productos.Size = new System.Drawing.Size(184, 26);
            this.Productos.Text = "Productos";
            this.Productos.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // Almacen
            // 
            this.Almacen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OrdenCompra,
            this.Remito,
            this.Stock});
            this.Almacen.Name = "Almacen";
            this.Almacen.Size = new System.Drawing.Size(66, 20);
            this.Almacen.Text = "Almacen";
            // 
            // OrdenCompra
            // 
            this.OrdenCompra.Image = global::FactorySys.Properties.Resources.file_edit;
            this.OrdenCompra.Name = "OrdenCompra";
            this.OrdenCompra.Size = new System.Drawing.Size(169, 22);
            this.OrdenCompra.Text = "Orden de Compra";
            this.OrdenCompra.Click += new System.EventHandler(this.ordenDeCompraToolStripMenuItem_Click);
            // 
            // Remito
            // 
            this.Remito.Image = global::FactorySys.Properties.Resources.file_edit;
            this.Remito.Name = "Remito";
            this.Remito.Size = new System.Drawing.Size(169, 22);
            this.Remito.Text = "Remito";
            this.Remito.Click += new System.EventHandler(this.remitoToolStripMenuItem_Click);
            // 
            // Stock
            // 
            this.Stock.Image = global::FactorySys.Properties.Resources.objects;
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(169, 22);
            this.Stock.Text = "Stock";
            this.Stock.Click += new System.EventHandler(this.stockToolStripMenuItem_Click);
            // 
            // Seguridad
            // 
            this.Seguridad.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Usuarios,
            this.Grupos,
            this.CopiaSeguridad,
            this.AuTarea,
            this.AuLoginOut});
            this.Seguridad.Name = "Seguridad";
            this.Seguridad.Size = new System.Drawing.Size(72, 20);
            this.Seguridad.Text = "Seguridad";
            // 
            // Usuarios
            // 
            this.Usuarios.Image = global::FactorySys.Properties.Resources.user;
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.Size = new System.Drawing.Size(184, 26);
            this.Usuarios.Text = "Usuarios";
            this.Usuarios.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // Grupos
            // 
            this.Grupos.Image = global::FactorySys.Properties.Resources.users;
            this.Grupos.Name = "Grupos";
            this.Grupos.Size = new System.Drawing.Size(184, 26);
            this.Grupos.Text = "Grupos";
            this.Grupos.Click += new System.EventHandler(this.grupoToolStripMenuItem_Click);
            // 
            // CopiaSeguridad
            // 
            this.CopiaSeguridad.Image = global::FactorySys.Properties.Resources.hd;
            this.CopiaSeguridad.Name = "CopiaSeguridad";
            this.CopiaSeguridad.Size = new System.Drawing.Size(184, 26);
            this.CopiaSeguridad.Text = "Copia de seguridad";
            this.CopiaSeguridad.Click += new System.EventHandler(this.Backup_Click);
            // 
            // AuTarea
            // 
            this.AuTarea.Image = global::FactorySys.Properties.Resources.favorits;
            this.AuTarea.Name = "AuTarea";
            this.AuTarea.Size = new System.Drawing.Size(184, 26);
            this.AuTarea.Text = "Au. Tareas";
            this.AuTarea.Click += new System.EventHandler(this.Au_Tareas_Click);
            // 
            // AuLoginOut
            // 
            this.AuLoginOut.Image = global::FactorySys.Properties.Resources.favorits;
            this.AuLoginOut.Name = "AuLoginOut";
            this.AuLoginOut.Size = new System.Drawing.Size(184, 26);
            this.AuLoginOut.Text = "Au. Log In/Out";
            this.AuLoginOut.Click += new System.EventHandler(this.Au_LogInOut_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Gestion,
            this.Almacen,
            this.produccionToolStripMenuItem,
            this.Seguridad});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(656, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip2";
            // 
            // produccionToolStripMenuItem
            // 
            this.produccionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Pedido,
            this.OrdenF,
            this.Fabrica});
            this.produccionToolStripMenuItem.Name = "produccionToolStripMenuItem";
            this.produccionToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.produccionToolStripMenuItem.Text = "Produccion";
            // 
            // Pedido
            // 
            this.Pedido.Image = global::FactorySys.Properties.Resources.apps;
            this.Pedido.Name = "Pedido";
            this.Pedido.Size = new System.Drawing.Size(187, 22);
            this.Pedido.Text = "Pedidos";
            this.Pedido.Click += new System.EventHandler(this.pedidosToolStripMenuItem_Click);
            // 
            // OrdenF
            // 
            this.OrdenF.Image = global::FactorySys.Properties.Resources.banner;
            this.OrdenF.Name = "OrdenF";
            this.OrdenF.Size = new System.Drawing.Size(187, 22);
            this.OrdenF.Text = "Orden de Fabricacion";
            this.OrdenF.Click += new System.EventHandler(this.ordenDeFabricacionToolStripMenuItem_Click);
            // 
            // Fabrica
            // 
            this.Fabrica.Image = global::FactorySys.Properties.Resources.paste;
            this.Fabrica.Name = "Fabrica";
            this.Fabrica.Size = new System.Drawing.Size(187, 22);
            this.Fabrica.Text = "Fábrica";
            this.Fabrica.Click += new System.EventHandler(this.fábricaToolStripMenuItem_Click);
            // 
            // btnCERRAR
            // 
            this.btnCERRAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCERRAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCERRAR.Image = global::FactorySys.Properties.Resources.back;
            this.btnCERRAR.Location = new System.Drawing.Point(10, 338);
            this.btnCERRAR.Name = "btnCERRAR";
            this.btnCERRAR.Size = new System.Drawing.Size(113, 65);
            this.btnCERRAR.TabIndex = 8;
            this.btnCERRAR.Text = "Cerrar Sesion";
            this.btnCERRAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCERRAR.UseVisualStyleBackColor = true;
            this.btnCERRAR.Click += new System.EventHandler(this.btnCERRAR_Click);
            // 
            // btnSALIR
            // 
            this.btnSALIR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSALIR.AutoSize = true;
            this.btnSALIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSALIR.Image = global::FactorySys.Properties.Resources.home;
            this.btnSALIR.Location = new System.Drawing.Point(536, 338);
            this.btnSALIR.Name = "btnSALIR";
            this.btnSALIR.Size = new System.Drawing.Size(110, 65);
            this.btnSALIR.TabIndex = 0;
            this.btnSALIR.Text = "Salir";
            this.btnSALIR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSALIR.UseVisualStyleBackColor = true;
            this.btnSALIR.Click += new System.EventHandler(this.btnSALIR_Click);
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(297, 198);
            this.lbl4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(94, 24);
            this.lbl4.TabIndex = 9;
            this.lbl4.TabStop = true;
            this.lbl4.Text = "linkLabel1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 158);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Bienvenido ";
            // 
            // btnMANUAL
            // 
            this.btnMANUAL.Location = new System.Drawing.Point(284, 1);
            this.btnMANUAL.Name = "btnMANUAL";
            this.btnMANUAL.Size = new System.Drawing.Size(75, 23);
            this.btnMANUAL.TabIndex = 11;
            this.btnMANUAL.Text = "Manual";
            this.btnMANUAL.UseVisualStyleBackColor = true;
            this.btnMANUAL.Click += new System.EventHandler(this.btnMANUAL_Click);
            // 
            // frmMAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(656, 416);
            this.Controls.Add(this.btnMANUAL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.btnCERRAR);
            this.Controls.Add(this.lblUSUARIO);
            this.Controls.Add(this.btnSALIR);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMAIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Gestion Fabrica de Sillones y Sofas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMAIN_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel lblUSUARIO;
        private System.Windows.Forms.Button btnCERRAR;
        private System.Windows.Forms.ToolStripMenuItem Gestion;
        private System.Windows.Forms.ToolStripMenuItem Proveedores;
        private System.Windows.Forms.ToolStripMenuItem Insumos;
        private System.Windows.Forms.ToolStripMenuItem Almacen;
        private System.Windows.Forms.ToolStripMenuItem OrdenCompra;
        private System.Windows.Forms.ToolStripMenuItem Remito;
        private System.Windows.Forms.ToolStripMenuItem Stock;
        private System.Windows.Forms.ToolStripMenuItem Seguridad;
        private System.Windows.Forms.ToolStripMenuItem Usuarios;
        private System.Windows.Forms.ToolStripMenuItem Grupos;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem Clientes;
        private System.Windows.Forms.ToolStripMenuItem produccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OrdenF;
        private System.Windows.Forms.Button btnSALIR;
        private System.Windows.Forms.ToolStripMenuItem Productos;
        private System.Windows.Forms.ToolStripMenuItem Pedido;
        private System.Windows.Forms.ToolStripMenuItem Fabrica;
        private System.Windows.Forms.ToolStripMenuItem CopiaSeguridad;
        private System.Windows.Forms.ToolStripMenuItem AuTarea;
        private System.Windows.Forms.ToolStripMenuItem AuLoginOut;
        private System.Windows.Forms.LinkLabel lbl4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMANUAL;
    }
}