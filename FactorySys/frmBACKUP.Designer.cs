namespace FactorySys
{
    partial class frmBACKUP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBACKUP));
            this.btnGENERAR = new System.Windows.Forms.Button();
            this.txtDESTINO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRUTA = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // btnGENERAR
            // 
            this.btnGENERAR.Location = new System.Drawing.Point(422, 66);
            this.btnGENERAR.Name = "btnGENERAR";
            this.btnGENERAR.Size = new System.Drawing.Size(93, 42);
            this.btnGENERAR.TabIndex = 0;
            this.btnGENERAR.Text = "Generar";
            this.btnGENERAR.UseVisualStyleBackColor = true;
            this.btnGENERAR.Click += new System.EventHandler(this.btnGENERAR_Click);
            // 
            // txtDESTINO
            // 
            this.txtDESTINO.Location = new System.Drawing.Point(100, 24);
            this.txtDESTINO.Name = "txtDESTINO";
            this.txtDESTINO.Size = new System.Drawing.Size(415, 22);
            this.txtDESTINO.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Destino:";
            // 
            // btnRUTA
            // 
            this.btnRUTA.Location = new System.Drawing.Point(37, 66);
            this.btnRUTA.Name = "btnRUTA";
            this.btnRUTA.Size = new System.Drawing.Size(141, 42);
            this.btnRUTA.TabIndex = 3;
            this.btnRUTA.Text = "Buscar Ruta";
            this.btnRUTA.UseVisualStyleBackColor = true;
            this.btnRUTA.Click += new System.EventHandler(this.btnRUTA_Click);
            // 
            // frmBACKUP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 135);
            this.Controls.Add(this.btnRUTA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDESTINO);
            this.Controls.Add(this.btnGENERAR);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBACKUP";
            this.Text = "Copia de seguridad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGENERAR;
        private System.Windows.Forms.TextBox txtDESTINO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRUTA;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}