namespace FactorySys
{
    partial class frmOFS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOFS));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnVERIFICAR = new System.Windows.Forms.Button();
            this.btnELIMINAR = new System.Windows.Forms.Button();
            this.btnSALIR = new System.Windows.Forms.Button();
            this.btnMODIFICAR = new System.Windows.Forms.Button();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.dgvOF = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOF)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnVERIFICAR);
            this.groupBox2.Controls.Add(this.btnELIMINAR);
            this.groupBox2.Controls.Add(this.btnSALIR);
            this.groupBox2.Controls.Add(this.btnMODIFICAR);
            this.groupBox2.Controls.Add(this.btnAGREGAR);
            this.groupBox2.Controls.Add(this.dgvOF);
            this.groupBox2.Location = new System.Drawing.Point(16, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1137, 544);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // btnVERIFICAR
            // 
            this.btnVERIFICAR.Image = global::FactorySys.Properties.Resources.file_apply;
            this.btnVERIFICAR.Location = new System.Drawing.Point(474, 473);
            this.btnVERIFICAR.Margin = new System.Windows.Forms.Padding(4);
            this.btnVERIFICAR.Name = "btnVERIFICAR";
            this.btnVERIFICAR.Size = new System.Drawing.Size(147, 55);
            this.btnVERIFICAR.TabIndex = 7;
            this.btnVERIFICAR.Text = "Enviar a Fabrica";
            this.btnVERIFICAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVERIFICAR.UseVisualStyleBackColor = true;
            this.btnVERIFICAR.Click += new System.EventHandler(this.btnVERIFICAR_Click);
            // 
            // btnELIMINAR
            // 
            this.btnELIMINAR.Image = global::FactorySys.Properties.Resources.delete;
            this.btnELIMINAR.Location = new System.Drawing.Point(319, 473);
            this.btnELIMINAR.Margin = new System.Windows.Forms.Padding(4);
            this.btnELIMINAR.Name = "btnELIMINAR";
            this.btnELIMINAR.Size = new System.Drawing.Size(147, 55);
            this.btnELIMINAR.TabIndex = 6;
            this.btnELIMINAR.Text = "Dar de baja";
            this.btnELIMINAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnELIMINAR.UseVisualStyleBackColor = true;
            this.btnELIMINAR.Click += new System.EventHandler(this.btnELIMINAR_Click);
            // 
            // btnSALIR
            // 
            this.btnSALIR.Image = global::FactorySys.Properties.Resources.home;
            this.btnSALIR.Location = new System.Drawing.Point(983, 473);
            this.btnSALIR.Margin = new System.Windows.Forms.Padding(4);
            this.btnSALIR.Name = "btnSALIR";
            this.btnSALIR.Size = new System.Drawing.Size(147, 55);
            this.btnSALIR.TabIndex = 5;
            this.btnSALIR.Text = "Salir";
            this.btnSALIR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSALIR.UseVisualStyleBackColor = true;
            this.btnSALIR.Click += new System.EventHandler(this.btnSALIR_Click);
            // 
            // btnMODIFICAR
            // 
            this.btnMODIFICAR.Image = global::FactorySys.Properties.Resources.file_edit;
            this.btnMODIFICAR.Location = new System.Drawing.Point(164, 473);
            this.btnMODIFICAR.Margin = new System.Windows.Forms.Padding(4);
            this.btnMODIFICAR.Name = "btnMODIFICAR";
            this.btnMODIFICAR.Size = new System.Drawing.Size(147, 55);
            this.btnMODIFICAR.TabIndex = 4;
            this.btnMODIFICAR.Text = "Modificar";
            this.btnMODIFICAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMODIFICAR.UseVisualStyleBackColor = true;
            this.btnMODIFICAR.Click += new System.EventHandler(this.btnMODIFICAR_Click);
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.Image = global::FactorySys.Properties.Resources.add;
            this.btnAGREGAR.Location = new System.Drawing.Point(10, 473);
            this.btnAGREGAR.Margin = new System.Windows.Forms.Padding(4);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(147, 55);
            this.btnAGREGAR.TabIndex = 3;
            this.btnAGREGAR.Text = "Nuevo";
            this.btnAGREGAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAGREGAR.UseVisualStyleBackColor = true;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAGREGAR_Click);
            // 
            // dgvOF
            // 
            this.dgvOF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOF.Location = new System.Drawing.Point(11, 23);
            this.dgvOF.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOF.Name = "dgvOF";
            this.dgvOF.Size = new System.Drawing.Size(1119, 442);
            this.dgvOF.TabIndex = 2;
            // 
            // frmOFS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 571);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmOFS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordenes de fabricacion";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnELIMINAR;
        private System.Windows.Forms.Button btnSALIR;
        private System.Windows.Forms.Button btnMODIFICAR;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.DataGridView dgvOF;
        private System.Windows.Forms.Button btnVERIFICAR;
    }
}