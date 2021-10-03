namespace FactorySys
{
    partial class frmA_TAREAS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmA_TAREAS));
            this.dgvGRILLA = new System.Windows.Forms.DataGridView();
            this.txtTAREA = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.Accion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUSER = new System.Windows.Forms.TextBox();
            this.txtACCION = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGRILLA)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGRILLA
            // 
            this.dgvGRILLA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGRILLA.Location = new System.Drawing.Point(12, 105);
            this.dgvGRILLA.Name = "dgvGRILLA";
            this.dgvGRILLA.RowTemplate.Height = 24;
            this.dgvGRILLA.Size = new System.Drawing.Size(862, 559);
            this.dgvGRILLA.TabIndex = 0;
            // 
            // txtTAREA
            // 
            this.txtTAREA.Location = new System.Drawing.Point(405, 58);
            this.txtTAREA.Name = "txtTAREA";
            this.txtTAREA.Size = new System.Drawing.Size(128, 22);
            this.txtTAREA.TabIndex = 1;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(353, 61);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(46, 17);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Tarea";
            // 
            // Accion
            // 
            this.Accion.AutoSize = true;
            this.Accion.Location = new System.Drawing.Point(356, 32);
            this.Accion.Name = "Accion";
            this.Accion.Size = new System.Drawing.Size(43, 17);
            this.Accion.TabIndex = 4;
            this.Accion.Text = "Acion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Usuario";
            // 
            // txtUSER
            // 
            this.txtUSER.Location = new System.Drawing.Point(193, 29);
            this.txtUSER.Name = "txtUSER";
            this.txtUSER.Size = new System.Drawing.Size(128, 22);
            this.txtUSER.TabIndex = 9;
            // 
            // txtACCION
            // 
            this.txtACCION.Location = new System.Drawing.Point(405, 29);
            this.txtACCION.Name = "txtACCION";
            this.txtACCION.Size = new System.Drawing.Size(128, 22);
            this.txtACCION.TabIndex = 11;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Image = global::FactorySys.Properties.Resources.zoom_in;
            this.btnFiltrar.Location = new System.Drawing.Point(550, 30);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(149, 50);
            this.btnFiltrar.TabIndex = 77;
            this.btnFiltrar.Text = "BUSCAR";
            this.btnFiltrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // frmA_TAREAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 676);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.txtACCION);
            this.Controls.Add(this.txtUSER);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Accion);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtTAREA);
            this.Controls.Add(this.dgvGRILLA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmA_TAREAS";
            this.Text = "Auditoria Tareas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGRILLA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGRILLA;
        private System.Windows.Forms.TextBox txtTAREA;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label Accion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUSER;
        private System.Windows.Forms.TextBox txtACCION;
        private System.Windows.Forms.Button btnFiltrar;
    }
}