namespace FactorySys
{
    partial class frmORDEN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmORDEN));
            this.dtpFECHA = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvLINEAOC = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnINSUMO = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCANTIDAD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPRECIO = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPROVEEDOR = new System.Windows.Forms.TextBox();
            this.btnPROVEEDOR = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbENTREGA = new System.Windows.Forms.ComboBox();
            this.btnELIMINAR = new System.Windows.Forms.Button();
            this.txtINSUMO = new System.Windows.Forms.TextBox();
            this.txtTOTAL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnVERIFICAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLINEAOC)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpFECHA
            // 
            this.dtpFECHA.Location = new System.Drawing.Point(475, 27);
            this.dtpFECHA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFECHA.Name = "dtpFECHA";
            this.dtpFECHA.Size = new System.Drawing.Size(259, 22);
            this.dtpFECHA.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(413, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Proveedor:";
            // 
            // dgvLINEAOC
            // 
            this.dgvLINEAOC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLINEAOC.Location = new System.Drawing.Point(29, 82);
            this.dgvLINEAOC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvLINEAOC.Name = "dgvLINEAOC";
            this.dgvLINEAOC.Size = new System.Drawing.Size(813, 185);
            this.dgvLINEAOC.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(467, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Insumo";
            // 
            // btnINSUMO
            // 
            this.btnINSUMO.Image = ((System.Drawing.Image)(resources.GetObject("btnINSUMO.Image")));
            this.btnINSUMO.Location = new System.Drawing.Point(727, 48);
            this.btnINSUMO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnINSUMO.Name = "btnINSUMO";
            this.btnINSUMO.Size = new System.Drawing.Size(33, 31);
            this.btnINSUMO.TabIndex = 6;
            this.btnINSUMO.UseVisualStyleBackColor = true;
            this.btnINSUMO.Click += new System.EventHandler(this.btnINSUMO_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cantidad";
            // 
            // txtCANTIDAD
            // 
            this.txtCANTIDAD.Location = new System.Drawing.Point(167, 50);
            this.txtCANTIDAD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCANTIDAD.Name = "txtCANTIDAD";
            this.txtCANTIDAD.Size = new System.Drawing.Size(124, 22);
            this.txtCANTIDAD.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Precio";
            // 
            // txtPRECIO
            // 
            this.txtPRECIO.Location = new System.Drawing.Point(300, 50);
            this.txtPRECIO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPRECIO.Name = "txtPRECIO";
            this.txtPRECIO.Size = new System.Drawing.Size(124, 22);
            this.txtPRECIO.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPROVEEDOR);
            this.groupBox1.Controls.Add(this.btnPROVEEDOR);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpFECHA);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(915, 69);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cabecera";
            // 
            // txtPROVEEDOR
            // 
            this.txtPROVEEDOR.Location = new System.Drawing.Point(167, 27);
            this.txtPROVEEDOR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPROVEEDOR.Name = "txtPROVEEDOR";
            this.txtPROVEEDOR.Size = new System.Drawing.Size(148, 22);
            this.txtPROVEEDOR.TabIndex = 16;
            // 
            // btnPROVEEDOR
            // 
            this.btnPROVEEDOR.Image = ((System.Drawing.Image)(resources.GetObject("btnPROVEEDOR.Image")));
            this.btnPROVEEDOR.Location = new System.Drawing.Point(324, 23);
            this.btnPROVEEDOR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPROVEEDOR.Name = "btnPROVEEDOR";
            this.btnPROVEEDOR.Size = new System.Drawing.Size(33, 31);
            this.btnPROVEEDOR.TabIndex = 16;
            this.btnPROVEEDOR.UseVisualStyleBackColor = true;
            this.btnPROVEEDOR.Click += new System.EventHandler(this.btnPROVEEDOR_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cmbENTREGA);
            this.groupBox2.Controls.Add(this.btnELIMINAR);
            this.groupBox2.Controls.Add(this.txtINSUMO);
            this.groupBox2.Controls.Add(this.txtTOTAL);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtCANTIDAD);
            this.groupBox2.Controls.Add(this.dgvLINEAOC);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtPRECIO);
            this.groupBox2.Controls.Add(this.btnAGREGAR);
            this.groupBox2.Controls.Add(this.btnINSUMO);
            this.groupBox2.Location = new System.Drawing.Point(16, 91);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(915, 313);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(611, 31);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 17);
            this.label10.TabIndex = 30;
            this.label10.Text = "Entrega";
            // 
            // cmbENTREGA
            // 
            this.cmbENTREGA.FormattingEnabled = true;
            this.cmbENTREGA.Location = new System.Drawing.Point(567, 50);
            this.cmbENTREGA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbENTREGA.Name = "cmbENTREGA";
            this.cmbENTREGA.Size = new System.Drawing.Size(140, 24);
            this.cmbENTREGA.TabIndex = 29;
            // 
            // btnELIMINAR
            // 
            this.btnELIMINAR.Image = ((System.Drawing.Image)(resources.GetObject("btnELIMINAR.Image")));
            this.btnELIMINAR.Location = new System.Drawing.Point(809, 48);
            this.btnELIMINAR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnELIMINAR.Name = "btnELIMINAR";
            this.btnELIMINAR.Size = new System.Drawing.Size(33, 31);
            this.btnELIMINAR.TabIndex = 12;
            this.btnELIMINAR.UseVisualStyleBackColor = true;
            this.btnELIMINAR.Click += new System.EventHandler(this.btnELIMINAR_Click);
            // 
            // txtINSUMO
            // 
            this.txtINSUMO.Location = new System.Drawing.Point(433, 50);
            this.txtINSUMO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtINSUMO.Name = "txtINSUMO";
            this.txtINSUMO.Size = new System.Drawing.Size(124, 22);
            this.txtINSUMO.TabIndex = 15;
            // 
            // txtTOTAL
            // 
            this.txtTOTAL.Location = new System.Drawing.Point(632, 274);
            this.txtTOTAL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTOTAL.Name = "txtTOTAL";
            this.txtTOTAL.Size = new System.Drawing.Size(121, 22);
            this.txtTOTAL.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(579, 278);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Total:";
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.Image = ((System.Drawing.Image)(resources.GetObject("btnAGREGAR.Image")));
            this.btnAGREGAR.Location = new System.Drawing.Point(768, 48);
            this.btnAGREGAR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(33, 31);
            this.btnAGREGAR.TabIndex = 11;
            this.btnAGREGAR.UseVisualStyleBackColor = true;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAGREGAR_Click);
            // 
            // btnGUARDAR
            // 
            this.btnGUARDAR.Image = global::FactorySys.Properties.Resources.save;
            this.btnGUARDAR.Location = new System.Drawing.Point(564, 411);
            this.btnGUARDAR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(133, 52);
            this.btnGUARDAR.TabIndex = 13;
            this.btnGUARDAR.Text = "Guardar";
            this.btnGUARDAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGUARDAR.UseVisualStyleBackColor = true;
            this.btnGUARDAR.Click += new System.EventHandler(this.btnGUARDAR_Click);
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Image = global::FactorySys.Properties.Resources.cancel;
            this.btnCANCELAR.Location = new System.Drawing.Point(705, 411);
            this.btnCANCELAR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(133, 52);
            this.btnCANCELAR.TabIndex = 14;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // btnVERIFICAR
            // 
            this.btnVERIFICAR.Image = global::FactorySys.Properties.Resources.file_apply;
            this.btnVERIFICAR.Location = new System.Drawing.Point(423, 411);
            this.btnVERIFICAR.Margin = new System.Windows.Forms.Padding(4);
            this.btnVERIFICAR.Name = "btnVERIFICAR";
            this.btnVERIFICAR.Size = new System.Drawing.Size(133, 52);
            this.btnVERIFICAR.TabIndex = 16;
            this.btnVERIFICAR.Text = "Verificar";
            this.btnVERIFICAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVERIFICAR.UseVisualStyleBackColor = true;
            this.btnVERIFICAR.Click += new System.EventHandler(this.btnVERIFICAR_Click_1);
            // 
            // frmORDEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 485);
            this.Controls.Add(this.btnVERIFICAR);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.btnGUARDAR);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmORDEN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "::.. Orden de compra";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLINEAOC)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFECHA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvLINEAOC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnINSUMO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCANTIDAD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPRECIO;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnELIMINAR;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.TextBox txtPROVEEDOR;
        private System.Windows.Forms.Button btnPROVEEDOR;
        private System.Windows.Forms.TextBox txtINSUMO;
        private System.Windows.Forms.TextBox txtTOTAL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbENTREGA;
        private System.Windows.Forms.Button btnVERIFICAR;
        //private Microsoft.Reporting.WinForms.ReportViewer reportOC;
    }
}