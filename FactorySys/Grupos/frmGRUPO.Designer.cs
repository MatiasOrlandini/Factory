namespace FactorySys.Grupos
{
    partial class frmGRUPO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGRUPO));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNOMBRE = new System.Windows.Forms.TextBox();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblALTA = new System.Windows.Forms.Label();
            this.chklCONSULTA = new System.Windows.Forms.CheckedListBox();
            this.chklMODIFICACION = new System.Windows.Forms.CheckedListBox();
            this.chklBAJA = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chklALTA = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkALTA = new System.Windows.Forms.CheckBox();
            this.chkBAJA = new System.Windows.Forms.CheckBox();
            this.chkMODIFICAR = new System.Windows.Forms.CheckBox();
            this.chkCONSULTA = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Nombre";
            // 
            // txtNOMBRE
            // 
            this.txtNOMBRE.Location = new System.Drawing.Point(91, 30);
            this.txtNOMBRE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNOMBRE.Name = "txtNOMBRE";
            this.txtNOMBRE.Size = new System.Drawing.Size(175, 22);
            this.txtNOMBRE.TabIndex = 29;
            // 
            // btnGUARDAR
            // 
            this.btnGUARDAR.Image = global::FactorySys.Properties.Resources.save;
            this.btnGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGUARDAR.Location = new System.Drawing.Point(737, 15);
            this.btnGUARDAR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(131, 52);
            this.btnGUARDAR.TabIndex = 36;
            this.btnGUARDAR.Text = "Guardar";
            this.btnGUARDAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGUARDAR.UseVisualStyleBackColor = true;
            this.btnGUARDAR.Click += new System.EventHandler(this.btnGUARDAR_Click);
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Image = global::FactorySys.Properties.Resources.cancel;
            this.btnCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCANCELAR.Location = new System.Drawing.Point(876, 15);
            this.btnCANCELAR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(131, 52);
            this.btnCANCELAR.TabIndex = 37;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkCONSULTA);
            this.groupBox1.Controls.Add(this.chkMODIFICAR);
            this.groupBox1.Controls.Add(this.chkBAJA);
            this.groupBox1.Controls.Add(this.chkALTA);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblALTA);
            this.groupBox1.Controls.Add(this.chklCONSULTA);
            this.groupBox1.Controls.Add(this.chklMODIFICACION);
            this.groupBox1.Controls.Add(this.chklBAJA);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.chklALTA);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(16, 74);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(991, 479);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permisos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(796, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "CONSULTA";
            // 
            // lblALTA
            // 
            this.lblALTA.AutoSize = true;
            this.lblALTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblALTA.Location = new System.Drawing.Point(95, 20);
            this.lblALTA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblALTA.Name = "lblALTA";
            this.lblALTA.Size = new System.Drawing.Size(62, 24);
            this.lblALTA.TabIndex = 1;
            this.lblALTA.Text = "ALTA";
            // 
            // chklCONSULTA
            // 
            this.chklCONSULTA.FormattingEnabled = true;
            this.chklCONSULTA.Location = new System.Drawing.Point(750, 54);
            this.chklCONSULTA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chklCONSULTA.Name = "chklCONSULTA";
            this.chklCONSULTA.Size = new System.Drawing.Size(213, 378);
            this.chklCONSULTA.TabIndex = 6;
            // 
            // chklMODIFICACION
            // 
            this.chklMODIFICACION.FormattingEnabled = true;
            this.chklMODIFICACION.Location = new System.Drawing.Point(509, 54);
            this.chklMODIFICACION.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chklMODIFICACION.Name = "chklMODIFICACION";
            this.chklMODIFICACION.Size = new System.Drawing.Size(213, 378);
            this.chklMODIFICACION.TabIndex = 4;
            // 
            // chklBAJA
            // 
            this.chklBAJA.FormattingEnabled = true;
            this.chklBAJA.Location = new System.Drawing.Point(265, 54);
            this.chklBAJA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chklBAJA.Name = "chklBAJA";
            this.chklBAJA.Size = new System.Drawing.Size(213, 378);
            this.chklBAJA.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(293, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "BAJA";
            // 
            // chklALTA
            // 
            this.chklALTA.FormattingEnabled = true;
            this.chklALTA.Location = new System.Drawing.Point(29, 54);
            this.chklALTA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chklALTA.Name = "chklALTA";
            this.chklALTA.Size = new System.Drawing.Size(213, 378);
            this.chklALTA.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(525, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "MODIFICACION";
            // 
            // chkALTA
            // 
            this.chkALTA.AutoSize = true;
            this.chkALTA.Location = new System.Drawing.Point(172, 439);
            this.chkALTA.Name = "chkALTA";
            this.chkALTA.Size = new System.Drawing.Size(70, 21);
            this.chkALTA.TabIndex = 8;
            this.chkALTA.Text = "Todos";
            this.chkALTA.UseVisualStyleBackColor = true;
            this.chkALTA.CheckedChanged += new System.EventHandler(this.chkALTA_CheckedChanged);
            // 
            // chkBAJA
            // 
            this.chkBAJA.AutoSize = true;
            this.chkBAJA.Location = new System.Drawing.Point(408, 439);
            this.chkBAJA.Name = "chkBAJA";
            this.chkBAJA.Size = new System.Drawing.Size(70, 21);
            this.chkBAJA.TabIndex = 9;
            this.chkBAJA.Text = "Todos";
            this.chkBAJA.UseVisualStyleBackColor = true;
            this.chkBAJA.CheckedChanged += new System.EventHandler(this.chkBAJA_CheckedChanged);
            // 
            // chkMODIFICAR
            // 
            this.chkMODIFICAR.AutoSize = true;
            this.chkMODIFICAR.Location = new System.Drawing.Point(652, 439);
            this.chkMODIFICAR.Name = "chkMODIFICAR";
            this.chkMODIFICAR.Size = new System.Drawing.Size(70, 21);
            this.chkMODIFICAR.TabIndex = 10;
            this.chkMODIFICAR.Text = "Todos";
            this.chkMODIFICAR.UseVisualStyleBackColor = true;
            this.chkMODIFICAR.CheckedChanged += new System.EventHandler(this.chkMODIFICAR_CheckedChanged);
            // 
            // chkCONSULTA
            // 
            this.chkCONSULTA.AutoSize = true;
            this.chkCONSULTA.Location = new System.Drawing.Point(893, 439);
            this.chkCONSULTA.Name = "chkCONSULTA";
            this.chkCONSULTA.Size = new System.Drawing.Size(70, 21);
            this.chkCONSULTA.TabIndex = 11;
            this.chkCONSULTA.Text = "Todos";
            this.chkCONSULTA.UseVisualStyleBackColor = true;
            this.chkCONSULTA.CheckedChanged += new System.EventHandler(this.chkCONSULTA_CheckedChanged);
            // 
            // frmGRUPO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 566);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGUARDAR);
            this.Controls.Add(this.txtNOMBRE);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmGRUPO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grupo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNOMBRE;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox chklCONSULTA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox chklMODIFICACION;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox chklBAJA;
        private System.Windows.Forms.Label lblALTA;
        private System.Windows.Forms.CheckedListBox chklALTA;
        private System.Windows.Forms.CheckBox chkCONSULTA;
        private System.Windows.Forms.CheckBox chkMODIFICAR;
        private System.Windows.Forms.CheckBox chkBAJA;
        private System.Windows.Forms.CheckBox chkALTA;
    }
}