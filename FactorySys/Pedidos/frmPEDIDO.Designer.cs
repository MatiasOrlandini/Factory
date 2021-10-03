namespace FactorySys
{
    partial class frmPEDIDO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPEDIDO));
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.gbDETALLE = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTOTAL_TOTAL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDESCUENTO = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTOTAL = new System.Windows.Forms.TextBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.txtGANANCIA = new System.Windows.Forms.TextBox();
            this.chkDETALLE = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCOSTO_TOTAL = new System.Windows.Forms.TextBox();
            this.txtDETALLE = new System.Windows.Forms.RichTextBox();
            this.btnELIMINAR = new System.Windows.Forms.Button();
            this.txtPRODUCTO = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCANTIDAD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCOSTO = new System.Windows.Forms.TextBox();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.btnPRODUCTO = new System.Windows.Forms.Button();
            this.dgvLINEA_PEDIDO = new System.Windows.Forms.DataGridView();
            this.gbCABE = new System.Windows.Forms.GroupBox();
            this.txtPORCENTAJE = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCATEOGIRA = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTELEFONO = new System.Windows.Forms.TextBox();
            this.btnCLIENTE = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFECHA = new System.Windows.Forms.DateTimePicker();
            this.txtCLIENTE = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.chklisTAREAS = new System.Windows.Forms.CheckedListBox();
            this.gbTAREAS = new System.Windows.Forms.GroupBox();
            this.gbDETALLE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLINEA_PEDIDO)).BeginInit();
            this.gbCABE.SuspendLayout();
            this.gbTAREAS.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGUARDAR
            // 
            this.btnGUARDAR.Image = global::FactorySys.Properties.Resources.save;
            this.btnGUARDAR.Location = new System.Drawing.Point(898, 570);
            this.btnGUARDAR.Margin = new System.Windows.Forms.Padding(4);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(133, 52);
            this.btnGUARDAR.TabIndex = 7;
            this.btnGUARDAR.Text = "Guardar";
            this.btnGUARDAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGUARDAR.UseVisualStyleBackColor = true;
            this.btnGUARDAR.Click += new System.EventHandler(this.btnGUARDAR_Click);
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Image = global::FactorySys.Properties.Resources.cancel;
            this.btnCANCELAR.Location = new System.Drawing.Point(1039, 570);
            this.btnCANCELAR.Margin = new System.Windows.Forms.Padding(4);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(133, 52);
            this.btnCANCELAR.TabIndex = 6;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // gbDETALLE
            // 
            this.gbDETALLE.Controls.Add(this.label10);
            this.gbDETALLE.Controls.Add(this.txtTOTAL_TOTAL);
            this.gbDETALLE.Controls.Add(this.label5);
            this.gbDETALLE.Controls.Add(this.txtDESCUENTO);
            this.gbDETALLE.Controls.Add(this.label4);
            this.gbDETALLE.Controls.Add(this.txtTOTAL);
            this.gbDETALLE.Controls.Add(this.lbl4);
            this.gbDETALLE.Controls.Add(this.txtGANANCIA);
            this.gbDETALLE.Controls.Add(this.chkDETALLE);
            this.gbDETALLE.Controls.Add(this.label9);
            this.gbDETALLE.Controls.Add(this.txtCOSTO_TOTAL);
            this.gbDETALLE.Controls.Add(this.txtDETALLE);
            this.gbDETALLE.Controls.Add(this.btnELIMINAR);
            this.gbDETALLE.Controls.Add(this.txtPRODUCTO);
            this.gbDETALLE.Controls.Add(this.label6);
            this.gbDETALLE.Controls.Add(this.label7);
            this.gbDETALLE.Controls.Add(this.txtCANTIDAD);
            this.gbDETALLE.Controls.Add(this.label8);
            this.gbDETALLE.Controls.Add(this.txtCOSTO);
            this.gbDETALLE.Controls.Add(this.btnAGREGAR);
            this.gbDETALLE.Controls.Add(this.btnPRODUCTO);
            this.gbDETALLE.Controls.Add(this.dgvLINEA_PEDIDO);
            this.gbDETALLE.Location = new System.Drawing.Point(13, 131);
            this.gbDETALLE.Margin = new System.Windows.Forms.Padding(4);
            this.gbDETALLE.Name = "gbDETALLE";
            this.gbDETALLE.Padding = new System.Windows.Forms.Padding(4);
            this.gbDETALLE.Size = new System.Drawing.Size(1207, 382);
            this.gbDETALLE.TabIndex = 5;
            this.gbDETALLE.TabStop = false;
            this.gbDETALLE.Text = "Pedido - Productos";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(831, 350);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 17);
            this.label10.TabIndex = 36;
            this.label10.Text = "Total";
            // 
            // txtTOTAL_TOTAL
            // 
            this.txtTOTAL_TOTAL.Enabled = false;
            this.txtTOTAL_TOTAL.Location = new System.Drawing.Point(880, 346);
            this.txtTOTAL_TOTAL.Margin = new System.Windows.Forms.Padding(4);
            this.txtTOTAL_TOTAL.Name = "txtTOTAL_TOTAL";
            this.txtTOTAL_TOTAL.Size = new System.Drawing.Size(129, 22);
            this.txtTOTAL_TOTAL.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(793, 318);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "Descuento";
            // 
            // txtDESCUENTO
            // 
            this.txtDESCUENTO.Enabled = false;
            this.txtDESCUENTO.Location = new System.Drawing.Point(880, 314);
            this.txtDESCUENTO.Margin = new System.Windows.Forms.Padding(4);
            this.txtDESCUENTO.Name = "txtDESCUENTO";
            this.txtDESCUENTO.Size = new System.Drawing.Size(129, 22);
            this.txtDESCUENTO.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(909, 262);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Sub Total";
            // 
            // txtTOTAL
            // 
            this.txtTOTAL.Enabled = false;
            this.txtTOTAL.Location = new System.Drawing.Point(880, 282);
            this.txtTOTAL.Margin = new System.Windows.Forms.Padding(4);
            this.txtTOTAL.Name = "txtTOTAL";
            this.txtTOTAL.Size = new System.Drawing.Size(129, 22);
            this.txtTOTAL.TabIndex = 31;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(633, 18);
            this.lbl4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(85, 17);
            this.lbl4.TabIndex = 29;
            this.lbl4.Text = "Ganancia %";
            // 
            // txtGANANCIA
            // 
            this.txtGANANCIA.Location = new System.Drawing.Point(612, 39);
            this.txtGANANCIA.Margin = new System.Windows.Forms.Padding(4);
            this.txtGANANCIA.Name = "txtGANANCIA";
            this.txtGANANCIA.Size = new System.Drawing.Size(124, 22);
            this.txtGANANCIA.TabIndex = 30;
            // 
            // chkDETALLE
            // 
            this.chkDETALLE.AutoSize = true;
            this.chkDETALLE.Location = new System.Drawing.Point(1060, 43);
            this.chkDETALLE.Margin = new System.Windows.Forms.Padding(4);
            this.chkDETALLE.Name = "chkDETALLE";
            this.chkDETALLE.Size = new System.Drawing.Size(74, 21);
            this.chkDETALLE.TabIndex = 28;
            this.chkDETALLE.Text = "Detalle";
            this.chkDETALLE.UseVisualStyleBackColor = true;
            this.chkDETALLE.CheckedChanged += new System.EventHandler(this.chkDETALLE_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(765, 263);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "Costo total";
            // 
            // txtCOSTO_TOTAL
            // 
            this.txtCOSTO_TOTAL.Enabled = false;
            this.txtCOSTO_TOTAL.Location = new System.Drawing.Point(741, 282);
            this.txtCOSTO_TOTAL.Margin = new System.Windows.Forms.Padding(4);
            this.txtCOSTO_TOTAL.Name = "txtCOSTO_TOTAL";
            this.txtCOSTO_TOTAL.Size = new System.Drawing.Size(129, 22);
            this.txtCOSTO_TOTAL.TabIndex = 25;
            // 
            // txtDETALLE
            // 
            this.txtDETALLE.BackColor = System.Drawing.Color.DarkGray;
            this.txtDETALLE.Enabled = false;
            this.txtDETALLE.Location = new System.Drawing.Point(1019, 71);
            this.txtDETALLE.Margin = new System.Windows.Forms.Padding(4);
            this.txtDETALLE.Name = "txtDETALLE";
            this.txtDETALLE.Size = new System.Drawing.Size(173, 184);
            this.txtDETALLE.TabIndex = 8;
            this.txtDETALLE.Text = "";
            // 
            // btnELIMINAR
            // 
            this.btnELIMINAR.Image = ((System.Drawing.Image)(resources.GetObject("btnELIMINAR.Image")));
            this.btnELIMINAR.Location = new System.Drawing.Point(828, 36);
            this.btnELIMINAR.Margin = new System.Windows.Forms.Padding(4);
            this.btnELIMINAR.Name = "btnELIMINAR";
            this.btnELIMINAR.Size = new System.Drawing.Size(33, 31);
            this.btnELIMINAR.TabIndex = 23;
            this.btnELIMINAR.UseVisualStyleBackColor = true;
            this.btnELIMINAR.Click += new System.EventHandler(this.btnELIMINAR_Click);
            // 
            // txtPRODUCTO
            // 
            this.txtPRODUCTO.Enabled = false;
            this.txtPRODUCTO.Location = new System.Drawing.Point(171, 39);
            this.txtPRODUCTO.Margin = new System.Windows.Forms.Padding(4);
            this.txtPRODUCTO.Name = "txtPRODUCTO";
            this.txtPRODUCTO.Size = new System.Drawing.Size(164, 22);
            this.txtPRODUCTO.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(379, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Cantidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(221, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Producto";
            // 
            // txtCANTIDAD
            // 
            this.txtCANTIDAD.Location = new System.Drawing.Point(344, 39);
            this.txtCANTIDAD.Margin = new System.Windows.Forms.Padding(4);
            this.txtCANTIDAD.Name = "txtCANTIDAD";
            this.txtCANTIDAD.Size = new System.Drawing.Size(124, 22);
            this.txtCANTIDAD.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(515, 20);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Costo";
            // 
            // txtCOSTO
            // 
            this.txtCOSTO.Location = new System.Drawing.Point(477, 39);
            this.txtCOSTO.Margin = new System.Windows.Forms.Padding(4);
            this.txtCOSTO.Name = "txtCOSTO";
            this.txtCOSTO.Size = new System.Drawing.Size(124, 22);
            this.txtCOSTO.TabIndex = 21;
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.Image = ((System.Drawing.Image)(resources.GetObject("btnAGREGAR.Image")));
            this.btnAGREGAR.Location = new System.Drawing.Point(787, 36);
            this.btnAGREGAR.Margin = new System.Windows.Forms.Padding(4);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(33, 31);
            this.btnAGREGAR.TabIndex = 22;
            this.btnAGREGAR.UseVisualStyleBackColor = true;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAGREGAR_Click);
            // 
            // btnPRODUCTO
            // 
            this.btnPRODUCTO.Image = ((System.Drawing.Image)(resources.GetObject("btnPRODUCTO.Image")));
            this.btnPRODUCTO.Location = new System.Drawing.Point(745, 36);
            this.btnPRODUCTO.Margin = new System.Windows.Forms.Padding(4);
            this.btnPRODUCTO.Name = "btnPRODUCTO";
            this.btnPRODUCTO.Size = new System.Drawing.Size(33, 31);
            this.btnPRODUCTO.TabIndex = 17;
            this.btnPRODUCTO.UseVisualStyleBackColor = true;
            this.btnPRODUCTO.Click += new System.EventHandler(this.btnPRODUCTO_Click);
            // 
            // dgvLINEA_PEDIDO
            // 
            this.dgvLINEA_PEDIDO.AllowUserToAddRows = false;
            this.dgvLINEA_PEDIDO.AllowUserToDeleteRows = false;
            this.dgvLINEA_PEDIDO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLINEA_PEDIDO.Location = new System.Drawing.Point(19, 71);
            this.dgvLINEA_PEDIDO.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLINEA_PEDIDO.Name = "dgvLINEA_PEDIDO";
            this.dgvLINEA_PEDIDO.ReadOnly = true;
            this.dgvLINEA_PEDIDO.Size = new System.Drawing.Size(992, 185);
            this.dgvLINEA_PEDIDO.TabIndex = 8;
            // 
            // gbCABE
            // 
            this.gbCABE.Controls.Add(this.txtPORCENTAJE);
            this.gbCABE.Controls.Add(this.label12);
            this.gbCABE.Controls.Add(this.txtCATEOGIRA);
            this.gbCABE.Controls.Add(this.label11);
            this.gbCABE.Controls.Add(this.txtTELEFONO);
            this.gbCABE.Controls.Add(this.btnCLIENTE);
            this.gbCABE.Controls.Add(this.label1);
            this.gbCABE.Controls.Add(this.label2);
            this.gbCABE.Controls.Add(this.label3);
            this.gbCABE.Controls.Add(this.dtpFECHA);
            this.gbCABE.Controls.Add(this.txtCLIENTE);
            this.gbCABE.Location = new System.Drawing.Point(13, 13);
            this.gbCABE.Margin = new System.Windows.Forms.Padding(4);
            this.gbCABE.Name = "gbCABE";
            this.gbCABE.Padding = new System.Windows.Forms.Padding(4);
            this.gbCABE.Size = new System.Drawing.Size(1207, 111);
            this.gbCABE.TabIndex = 4;
            this.gbCABE.TabStop = false;
            this.gbCABE.Text = "Cliente del pedido";
            // 
            // txtPORCENTAJE
            // 
            this.txtPORCENTAJE.Enabled = false;
            this.txtPORCENTAJE.Location = new System.Drawing.Point(435, 64);
            this.txtPORCENTAJE.Margin = new System.Windows.Forms.Padding(4);
            this.txtPORCENTAJE.Name = "txtPORCENTAJE";
            this.txtPORCENTAJE.Size = new System.Drawing.Size(44, 22);
            this.txtPORCENTAJE.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(348, 68);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 17);
            this.label12.TabIndex = 10;
            this.label12.Text = "Descuento";
            // 
            // txtCATEOGIRA
            // 
            this.txtCATEOGIRA.Enabled = false;
            this.txtCATEOGIRA.Location = new System.Drawing.Point(285, 64);
            this.txtCATEOGIRA.Margin = new System.Windows.Forms.Padding(4);
            this.txtCATEOGIRA.Name = "txtCATEOGIRA";
            this.txtCATEOGIRA.Size = new System.Drawing.Size(35, 22);
            this.txtCATEOGIRA.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(204, 68);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 17);
            this.label11.TabIndex = 8;
            this.label11.Text = "Categoria:";
            // 
            // txtTELEFONO
            // 
            this.txtTELEFONO.Enabled = false;
            this.txtTELEFONO.Location = new System.Drawing.Point(696, 64);
            this.txtTELEFONO.Margin = new System.Windows.Forms.Padding(4);
            this.txtTELEFONO.Name = "txtTELEFONO";
            this.txtTELEFONO.Size = new System.Drawing.Size(152, 22);
            this.txtTELEFONO.TabIndex = 3;
            // 
            // btnCLIENTE
            // 
            this.btnCLIENTE.Image = ((System.Drawing.Image)(resources.GetObject("btnCLIENTE.Image")));
            this.btnCLIENTE.Location = new System.Drawing.Point(447, 28);
            this.btnCLIENTE.Margin = new System.Windows.Forms.Padding(4);
            this.btnCLIENTE.Name = "btnCLIENTE";
            this.btnCLIENTE.Size = new System.Drawing.Size(33, 31);
            this.btnCLIENTE.TabIndex = 2;
            this.btnCLIENTE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCLIENTE.UseVisualStyleBackColor = true;
            this.btnCLIENTE.Click += new System.EventHandler(this.btnCLIENTE_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(507, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha aproximada entrega:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(619, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Telefono:";
            // 
            // dtpFECHA
            // 
            this.dtpFECHA.Location = new System.Drawing.Point(696, 32);
            this.dtpFECHA.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFECHA.Name = "dtpFECHA";
            this.dtpFECHA.Size = new System.Drawing.Size(284, 22);
            this.dtpFECHA.TabIndex = 7;
            // 
            // txtCLIENTE
            // 
            this.txtCLIENTE.Enabled = false;
            this.txtCLIENTE.Location = new System.Drawing.Point(285, 32);
            this.txtCLIENTE.Margin = new System.Windows.Forms.Padding(4);
            this.txtCLIENTE.Name = "txtCLIENTE";
            this.txtCLIENTE.Size = new System.Drawing.Size(152, 22);
            this.txtCLIENTE.TabIndex = 5;
            this.txtCLIENTE.TextChanged += new System.EventHandler(this.txtCLIENTE_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(210, 17);
            this.label13.TabIndex = 10;
            this.label13.Text = "Seleccione las tareas a realizar:";
            // 
            // chklisTAREAS
            // 
            this.chklisTAREAS.FormattingEnabled = true;
            this.chklisTAREAS.Location = new System.Drawing.Point(25, 71);
            this.chklisTAREAS.Name = "chklisTAREAS";
            this.chklisTAREAS.Size = new System.Drawing.Size(226, 276);
            this.chklisTAREAS.TabIndex = 9;
            // 
            // gbTAREAS
            // 
            this.gbTAREAS.Controls.Add(this.chklisTAREAS);
            this.gbTAREAS.Controls.Add(this.label13);
            this.gbTAREAS.Location = new System.Drawing.Point(1227, 131);
            this.gbTAREAS.Name = "gbTAREAS";
            this.gbTAREAS.Size = new System.Drawing.Size(268, 373);
            this.gbTAREAS.TabIndex = 11;
            this.gbTAREAS.TabStop = false;
            this.gbTAREAS.Text = "Tareas";
            // 
            // frmPEDIDO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1507, 635);
            this.Controls.Add(this.gbTAREAS);
            this.Controls.Add(this.gbCABE);
            this.Controls.Add(this.gbDETALLE);
            this.Controls.Add(this.btnGUARDAR);
            this.Controls.Add(this.btnCANCELAR);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPEDIDO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido";
            this.gbDETALLE.ResumeLayout(false);
            this.gbDETALLE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLINEA_PEDIDO)).EndInit();
            this.gbCABE.ResumeLayout(false);
            this.gbCABE.PerformLayout();
            this.gbTAREAS.ResumeLayout(false);
            this.gbTAREAS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.GroupBox gbDETALLE;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCOSTO_TOTAL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbCABE;
        private System.Windows.Forms.TextBox txtTELEFONO;
        private System.Windows.Forms.Button btnCLIENTE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFECHA;
        private System.Windows.Forms.TextBox txtCLIENTE;
        private System.Windows.Forms.RichTextBox txtDETALLE;
        private System.Windows.Forms.CheckBox chkDETALLE;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTOTAL;
        private System.Windows.Forms.TextBox txtGANANCIA;
        private System.Windows.Forms.Button btnELIMINAR;
        private System.Windows.Forms.TextBox txtPRODUCTO;
        private System.Windows.Forms.TextBox txtCANTIDAD;
        private System.Windows.Forms.TextBox txtCOSTO;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.Button btnPRODUCTO;
        private System.Windows.Forms.DataGridView dgvLINEA_PEDIDO;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTOTAL_TOTAL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDESCUENTO;
        private System.Windows.Forms.TextBox txtPORCENTAJE;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCATEOGIRA;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckedListBox chklisTAREAS;
        private System.Windows.Forms.GroupBox gbTAREAS;
    }
}