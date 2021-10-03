namespace FactorySys
{
    partial class frmA_LOGINOUT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmA_LOGINOUT));
            this.dgvGRILLA = new System.Windows.Forms.DataGridView();
            this.txtUSUARIO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGRILLA)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGRILLA
            // 
            this.dgvGRILLA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGRILLA.Location = new System.Drawing.Point(12, 47);
            this.dgvGRILLA.Name = "dgvGRILLA";
            this.dgvGRILLA.RowTemplate.Height = 24;
            this.dgvGRILLA.Size = new System.Drawing.Size(622, 666);
            this.dgvGRILLA.TabIndex = 0;
            // 
            // txtUSUARIO
            // 
            this.txtUSUARIO.Location = new System.Drawing.Point(203, 12);
            this.txtUSUARIO.Name = "txtUSUARIO";
            this.txtUSUARIO.Size = new System.Drawing.Size(135, 22);
            this.txtUSUARIO.TabIndex = 1;
            this.txtUSUARIO.TextChanged += new System.EventHandler(this.txtUSUARIO_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtrar Usuario:";
            // 
            // frmA_LOGINOUT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 725);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUSUARIO);
            this.Controls.Add(this.dgvGRILLA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmA_LOGINOUT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auditoria Log In Out";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGRILLA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGRILLA;
        private System.Windows.Forms.TextBox txtUSUARIO;
        private System.Windows.Forms.Label label1;
    }
}