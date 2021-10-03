namespace FactorySys
{
    partial class frmFABRICA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFABRICA));
            this.gbTAREAS = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbESTADO = new System.Windows.Forms.ComboBox();
            this.cmbTAREAS = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnELIMINAR_PROCESO = new System.Windows.Forms.Button();
            this.btnAGREGAR_PROCESO = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvLINEA_FABRICACION = new System.Windows.Forms.DataGridView();
            this.txtDETALLE = new System.Windows.Forms.TextBox();
            this.gbTAREAS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLINEA_FABRICACION)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTAREAS
            // 
            this.gbTAREAS.Controls.Add(this.label1);
            this.gbTAREAS.Controls.Add(this.cmbESTADO);
            this.gbTAREAS.Controls.Add(this.cmbTAREAS);
            this.gbTAREAS.Controls.Add(this.label5);
            this.gbTAREAS.Controls.Add(this.btnELIMINAR_PROCESO);
            this.gbTAREAS.Controls.Add(this.btnAGREGAR_PROCESO);
            this.gbTAREAS.Controls.Add(this.label2);
            this.gbTAREAS.Controls.Add(this.dgvLINEA_FABRICACION);
            this.gbTAREAS.Controls.Add(this.txtDETALLE);
            this.gbTAREAS.Location = new System.Drawing.Point(13, 13);
            this.gbTAREAS.Margin = new System.Windows.Forms.Padding(4);
            this.gbTAREAS.Name = "gbTAREAS";
            this.gbTAREAS.Padding = new System.Windows.Forms.Padding(4);
            this.gbTAREAS.Size = new System.Drawing.Size(870, 331);
            this.gbTAREAS.TabIndex = 19;
            this.gbTAREAS.TabStop = false;
            this.gbTAREAS.Text = "Tareas de la Orden de Fabricacion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "Estado Orden";
            // 
            // cmbESTADO
            // 
            this.cmbESTADO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbESTADO.Enabled = false;
            this.cmbESTADO.FormattingEnabled = true;
            this.cmbESTADO.Location = new System.Drawing.Point(54, 52);
            this.cmbESTADO.Name = "cmbESTADO";
            this.cmbESTADO.Size = new System.Drawing.Size(166, 25);
            this.cmbESTADO.TabIndex = 39;
            // 
            // cmbTAREAS
            // 
            this.cmbTAREAS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbTAREAS.Enabled = false;
            this.cmbTAREAS.FormattingEnabled = true;
            this.cmbTAREAS.Items.AddRange(new object[] {
            "Cortado",
            "Lijado",
            "Ensamblado",
            "Pintura"});
            this.cmbTAREAS.Location = new System.Drawing.Point(227, 52);
            this.cmbTAREAS.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTAREAS.Name = "cmbTAREAS";
            this.cmbTAREAS.Size = new System.Drawing.Size(145, 24);
            this.cmbTAREAS.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Tarea a realizar";
            // 
            // btnELIMINAR_PROCESO
            // 
            this.btnELIMINAR_PROCESO.Image = ((System.Drawing.Image)(resources.GetObject("btnELIMINAR_PROCESO.Image")));
            this.btnELIMINAR_PROCESO.Location = new System.Drawing.Point(789, 48);
            this.btnELIMINAR_PROCESO.Margin = new System.Windows.Forms.Padding(4);
            this.btnELIMINAR_PROCESO.Name = "btnELIMINAR_PROCESO";
            this.btnELIMINAR_PROCESO.Size = new System.Drawing.Size(33, 31);
            this.btnELIMINAR_PROCESO.TabIndex = 38;
            this.btnELIMINAR_PROCESO.UseVisualStyleBackColor = true;
            this.btnELIMINAR_PROCESO.Click += new System.EventHandler(this.btnELIMINAR_PROCESO_Click);
            // 
            // btnAGREGAR_PROCESO
            // 
            this.btnAGREGAR_PROCESO.Image = ((System.Drawing.Image)(resources.GetObject("btnAGREGAR_PROCESO.Image")));
            this.btnAGREGAR_PROCESO.Location = new System.Drawing.Point(748, 48);
            this.btnAGREGAR_PROCESO.Margin = new System.Windows.Forms.Padding(4);
            this.btnAGREGAR_PROCESO.Name = "btnAGREGAR_PROCESO";
            this.btnAGREGAR_PROCESO.Size = new System.Drawing.Size(33, 31);
            this.btnAGREGAR_PROCESO.TabIndex = 37;
            this.btnAGREGAR_PROCESO.UseVisualStyleBackColor = true;
            this.btnAGREGAR_PROCESO.Click += new System.EventHandler(this.btnAGREGAR_PROCESO_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(526, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Detalle";
            // 
            // dgvLINEA_FABRICACION
            // 
            this.dgvLINEA_FABRICACION.AllowUserToAddRows = false;
            this.dgvLINEA_FABRICACION.AllowUserToDeleteRows = false;
            this.dgvLINEA_FABRICACION.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLINEA_FABRICACION.Location = new System.Drawing.Point(45, 87);
            this.dgvLINEA_FABRICACION.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLINEA_FABRICACION.Name = "dgvLINEA_FABRICACION";
            this.dgvLINEA_FABRICACION.ReadOnly = true;
            this.dgvLINEA_FABRICACION.Size = new System.Drawing.Size(794, 212);
            this.dgvLINEA_FABRICACION.TabIndex = 36;
            // 
            // txtDETALLE
            // 
            this.txtDETALLE.Location = new System.Drawing.Point(380, 52);
            this.txtDETALLE.Margin = new System.Windows.Forms.Padding(4);
            this.txtDETALLE.Name = "txtDETALLE";
            this.txtDETALLE.Size = new System.Drawing.Size(352, 22);
            this.txtDETALLE.TabIndex = 17;
            this.txtDETALLE.Text = "REALIZADO -";
            // 
            // frmFABRICA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 360);
            this.Controls.Add(this.gbTAREAS);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFABRICA";
            this.Text = "Tareas a realizar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFABRICA_FormClosing);
            this.gbTAREAS.ResumeLayout(false);
            this.gbTAREAS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLINEA_FABRICACION)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTAREAS;
        private System.Windows.Forms.ComboBox cmbTAREAS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnELIMINAR_PROCESO;
        private System.Windows.Forms.Button btnAGREGAR_PROCESO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvLINEA_FABRICACION;
        private System.Windows.Forms.TextBox txtDETALLE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbESTADO;
    }
}