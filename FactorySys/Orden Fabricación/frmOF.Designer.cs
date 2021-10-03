namespace FactorySys
{
    partial class frmOF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOF));
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.btnVERIFICAR = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSTOCK = new System.Windows.Forms.Button();
            this.dgvLINEA_INSUMOS = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbOF = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbESTADO = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDESCRIPCION = new System.Windows.Forms.RichTextBox();
            this.dtpFECHA_OF = new System.Windows.Forms.DateTimePicker();
            this.txtCODIGO_OF = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtUSUARIO = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.gbORIGEN = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTOTAL = new System.Windows.Forms.TextBox();
            this.dgvLINEA_PEDIDO = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCOSTO_TOTAL = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNOMBRE = new System.Windows.Forms.TextBox();
            this.txtDIRECCION = new System.Windows.Forms.TextBox();
            this.txtPEDIDO = new System.Windows.Forms.TextBox();
            this.txtCLIENTE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLOCALIDAD = new System.Windows.Forms.TextBox();
            this.btnBUSCAR_PEDIDO = new System.Windows.Forms.Button();
            this.txtCLASE = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbTareas = new System.Windows.Forms.TabPage();
            this.dgvLINEA_FABRICACION = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLINEA_INSUMOS)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.gbOF.SuspendLayout();
            this.gbORIGEN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLINEA_PEDIDO)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tbTareas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLINEA_FABRICACION)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Image = global::FactorySys.Properties.Resources.cancel;
            this.btnCANCELAR.Location = new System.Drawing.Point(869, 747);
            this.btnCANCELAR.Margin = new System.Windows.Forms.Padding(4);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(131, 52);
            this.btnCANCELAR.TabIndex = 60;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // btnGUARDAR
            // 
            this.btnGUARDAR.Image = global::FactorySys.Properties.Resources.save;
            this.btnGUARDAR.Location = new System.Drawing.Point(731, 747);
            this.btnGUARDAR.Margin = new System.Windows.Forms.Padding(4);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(131, 52);
            this.btnGUARDAR.TabIndex = 59;
            this.btnGUARDAR.Text = "Guardar";
            this.btnGUARDAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGUARDAR.UseVisualStyleBackColor = true;
            this.btnGUARDAR.Click += new System.EventHandler(this.btnGUARDAR_Click);
            // 
            // btnVERIFICAR
            // 
            this.btnVERIFICAR.Image = global::FactorySys.Properties.Resources.file_apply;
            this.btnVERIFICAR.Location = new System.Drawing.Point(592, 747);
            this.btnVERIFICAR.Margin = new System.Windows.Forms.Padding(4);
            this.btnVERIFICAR.Name = "btnVERIFICAR";
            this.btnVERIFICAR.Size = new System.Drawing.Size(131, 52);
            this.btnVERIFICAR.TabIndex = 61;
            this.btnVERIFICAR.Text = "Verificar";
            this.btnVERIFICAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVERIFICAR.UseVisualStyleBackColor = true;
            this.btnVERIFICAR.Click += new System.EventHandler(this.btnVERIFICAR_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(980, 695);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Insumos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSTOCK);
            this.groupBox2.Controls.Add(this.dgvLINEA_INSUMOS);
            this.groupBox2.Location = new System.Drawing.Point(8, 7);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(943, 688);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Total insumos necesarios";
            // 
            // btnSTOCK
            // 
            this.btnSTOCK.Image = global::FactorySys.Properties.Resources.data;
            this.btnSTOCK.Location = new System.Drawing.Point(374, 31);
            this.btnSTOCK.Margin = new System.Windows.Forms.Padding(4);
            this.btnSTOCK.Name = "btnSTOCK";
            this.btnSTOCK.Size = new System.Drawing.Size(209, 53);
            this.btnSTOCK.TabIndex = 62;
            this.btnSTOCK.Text = "VER STOCK";
            this.btnSTOCK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSTOCK.UseVisualStyleBackColor = true;
            this.btnSTOCK.Click += new System.EventHandler(this.btnSTOCK_Click);
            // 
            // dgvLINEA_INSUMOS
            // 
            this.dgvLINEA_INSUMOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLINEA_INSUMOS.Location = new System.Drawing.Point(37, 92);
            this.dgvLINEA_INSUMOS.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLINEA_INSUMOS.Name = "dgvLINEA_INSUMOS";
            this.dgvLINEA_INSUMOS.Size = new System.Drawing.Size(862, 579);
            this.dgvLINEA_INSUMOS.TabIndex = 37;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbOF);
            this.tabPage1.Controls.Add(this.gbORIGEN);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(980, 695);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Origen";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gbOF
            // 
            this.gbOF.Controls.Add(this.label7);
            this.gbOF.Controls.Add(this.cmbESTADO);
            this.gbOF.Controls.Add(this.label6);
            this.gbOF.Controls.Add(this.txtDESCRIPCION);
            this.gbOF.Controls.Add(this.dtpFECHA_OF);
            this.gbOF.Controls.Add(this.txtCODIGO_OF);
            this.gbOF.Controls.Add(this.label19);
            this.gbOF.Controls.Add(this.label18);
            this.gbOF.Controls.Add(this.txtUSUARIO);
            this.gbOF.Controls.Add(this.label17);
            this.gbOF.Location = new System.Drawing.Point(8, 8);
            this.gbOF.Margin = new System.Windows.Forms.Padding(4);
            this.gbOF.Name = "gbOF";
            this.gbOF.Padding = new System.Windows.Forms.Padding(4);
            this.gbOF.Size = new System.Drawing.Size(961, 188);
            this.gbOF.TabIndex = 63;
            this.gbOF.TabStop = false;
            this.gbOF.Text = "Orden de Fabricacion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(439, 72);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 40;
            this.label7.Text = "Estado:";
            // 
            // cmbESTADO
            // 
            this.cmbESTADO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbESTADO.Enabled = false;
            this.cmbESTADO.FormattingEnabled = true;
            this.cmbESTADO.Location = new System.Drawing.Point(503, 69);
            this.cmbESTADO.Margin = new System.Windows.Forms.Padding(4);
            this.cmbESTADO.Name = "cmbESTADO";
            this.cmbESTADO.Size = new System.Drawing.Size(145, 24);
            this.cmbESTADO.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 114);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Descripcion:";
            // 
            // txtDESCRIPCION
            // 
            this.txtDESCRIPCION.Location = new System.Drawing.Point(157, 110);
            this.txtDESCRIPCION.Margin = new System.Windows.Forms.Padding(4);
            this.txtDESCRIPCION.Name = "txtDESCRIPCION";
            this.txtDESCRIPCION.Size = new System.Drawing.Size(612, 53);
            this.txtDESCRIPCION.TabIndex = 17;
            this.txtDESCRIPCION.Text = "Puede agregar una descripción, si lo desea.";
            // 
            // dtpFECHA_OF
            // 
            this.dtpFECHA_OF.Location = new System.Drawing.Point(500, 35);
            this.dtpFECHA_OF.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFECHA_OF.Name = "dtpFECHA_OF";
            this.dtpFECHA_OF.Size = new System.Drawing.Size(284, 22);
            this.dtpFECHA_OF.TabIndex = 15;
            // 
            // txtCODIGO_OF
            // 
            this.txtCODIGO_OF.Enabled = false;
            this.txtCODIGO_OF.Location = new System.Drawing.Point(172, 35);
            this.txtCODIGO_OF.Margin = new System.Windows.Forms.Padding(4);
            this.txtCODIGO_OF.Name = "txtCODIGO_OF";
            this.txtCODIGO_OF.Size = new System.Drawing.Size(184, 22);
            this.txtCODIGO_OF.TabIndex = 10;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(103, 70);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 17);
            this.label19.TabIndex = 13;
            this.label19.Text = "Usuario:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(84, 39);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 17);
            this.label18.TabIndex = 7;
            this.label18.Text = "Codigo OF:";
            // 
            // txtUSUARIO
            // 
            this.txtUSUARIO.Enabled = false;
            this.txtUSUARIO.Location = new System.Drawing.Point(172, 67);
            this.txtUSUARIO.Margin = new System.Windows.Forms.Padding(4);
            this.txtUSUARIO.Name = "txtUSUARIO";
            this.txtUSUARIO.Size = new System.Drawing.Size(184, 22);
            this.txtUSUARIO.TabIndex = 14;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(391, 39);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(104, 17);
            this.label17.TabIndex = 12;
            this.label17.Text = "Fecha entrega:";
            // 
            // gbORIGEN
            // 
            this.gbORIGEN.Controls.Add(this.label1);
            this.gbORIGEN.Controls.Add(this.txtTOTAL);
            this.gbORIGEN.Controls.Add(this.dgvLINEA_PEDIDO);
            this.gbORIGEN.Controls.Add(this.label15);
            this.gbORIGEN.Controls.Add(this.label9);
            this.gbORIGEN.Controls.Add(this.label13);
            this.gbORIGEN.Controls.Add(this.txtCOSTO_TOTAL);
            this.gbORIGEN.Controls.Add(this.label12);
            this.gbORIGEN.Controls.Add(this.label11);
            this.gbORIGEN.Controls.Add(this.label3);
            this.gbORIGEN.Controls.Add(this.txtNOMBRE);
            this.gbORIGEN.Controls.Add(this.txtDIRECCION);
            this.gbORIGEN.Controls.Add(this.txtPEDIDO);
            this.gbORIGEN.Controls.Add(this.txtCLIENTE);
            this.gbORIGEN.Controls.Add(this.label4);
            this.gbORIGEN.Controls.Add(this.txtLOCALIDAD);
            this.gbORIGEN.Controls.Add(this.btnBUSCAR_PEDIDO);
            this.gbORIGEN.Controls.Add(this.txtCLASE);
            this.gbORIGEN.Controls.Add(this.label10);
            this.gbORIGEN.Location = new System.Drawing.Point(8, 204);
            this.gbORIGEN.Margin = new System.Windows.Forms.Padding(4);
            this.gbORIGEN.Name = "gbORIGEN";
            this.gbORIGEN.Padding = new System.Windows.Forms.Padding(4);
            this.gbORIGEN.Size = new System.Drawing.Size(961, 475);
            this.gbORIGEN.TabIndex = 62;
            this.gbORIGEN.TabStop = false;
            this.gbORIGEN.Text = "Cliente/Pedido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(825, 420);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 41;
            this.label1.Text = "Total";
            // 
            // txtTOTAL
            // 
            this.txtTOTAL.Enabled = false;
            this.txtTOTAL.Location = new System.Drawing.Point(783, 439);
            this.txtTOTAL.Margin = new System.Windows.Forms.Padding(4);
            this.txtTOTAL.Name = "txtTOTAL";
            this.txtTOTAL.Size = new System.Drawing.Size(129, 22);
            this.txtTOTAL.TabIndex = 40;
            // 
            // dgvLINEA_PEDIDO
            // 
            this.dgvLINEA_PEDIDO.AllowUserToAddRows = false;
            this.dgvLINEA_PEDIDO.AllowUserToDeleteRows = false;
            this.dgvLINEA_PEDIDO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLINEA_PEDIDO.Location = new System.Drawing.Point(53, 254);
            this.dgvLINEA_PEDIDO.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLINEA_PEDIDO.Name = "dgvLINEA_PEDIDO";
            this.dgvLINEA_PEDIDO.ReadOnly = true;
            this.dgvLINEA_PEDIDO.Size = new System.Drawing.Size(860, 158);
            this.dgvLINEA_PEDIDO.TabIndex = 35;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(125, 121);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(127, 17);
            this.label15.TabIndex = 23;
            this.label15.Text = "Nombre y Apellido:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(668, 420);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 17);
            this.label9.TabIndex = 39;
            this.label9.Text = "Costo Total";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(497, 153);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 17);
            this.label13.TabIndex = 25;
            this.label13.Text = "Direccion:";
            // 
            // txtCOSTO_TOTAL
            // 
            this.txtCOSTO_TOTAL.Enabled = false;
            this.txtCOSTO_TOTAL.Location = new System.Drawing.Point(644, 439);
            this.txtCOSTO_TOTAL.Margin = new System.Windows.Forms.Padding(4);
            this.txtCOSTO_TOTAL.Name = "txtCOSTO_TOTAL";
            this.txtCOSTO_TOTAL.Size = new System.Drawing.Size(129, 22);
            this.txtCOSTO_TOTAL.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(143, 70);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 17);
            this.label12.TabIndex = 18;
            this.label12.Text = "Numero Cliente:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(177, 153);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 17);
            this.label11.TabIndex = 27;
            this.label11.Text = "Localidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 223);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Lista de productos del pedido ";
            // 
            // txtNOMBRE
            // 
            this.txtNOMBRE.Enabled = false;
            this.txtNOMBRE.Location = new System.Drawing.Point(260, 117);
            this.txtNOMBRE.Margin = new System.Windows.Forms.Padding(4);
            this.txtNOMBRE.Name = "txtNOMBRE";
            this.txtNOMBRE.Size = new System.Drawing.Size(212, 22);
            this.txtNOMBRE.TabIndex = 24;
            // 
            // txtDIRECCION
            // 
            this.txtDIRECCION.Enabled = false;
            this.txtDIRECCION.Location = new System.Drawing.Point(579, 149);
            this.txtDIRECCION.Margin = new System.Windows.Forms.Padding(4);
            this.txtDIRECCION.Name = "txtDIRECCION";
            this.txtDIRECCION.Size = new System.Drawing.Size(212, 22);
            this.txtDIRECCION.TabIndex = 26;
            // 
            // txtPEDIDO
            // 
            this.txtPEDIDO.Enabled = false;
            this.txtPEDIDO.Location = new System.Drawing.Point(260, 33);
            this.txtPEDIDO.Margin = new System.Windows.Forms.Padding(4);
            this.txtPEDIDO.Name = "txtPEDIDO";
            this.txtPEDIDO.Size = new System.Drawing.Size(212, 22);
            this.txtPEDIDO.TabIndex = 34;
            // 
            // txtCLIENTE
            // 
            this.txtCLIENTE.Enabled = false;
            this.txtCLIENTE.Location = new System.Drawing.Point(260, 66);
            this.txtCLIENTE.Margin = new System.Windows.Forms.Padding(4);
            this.txtCLIENTE.Name = "txtCLIENTE";
            this.txtCLIENTE.Size = new System.Drawing.Size(212, 22);
            this.txtCLIENTE.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Numero Pedido:";
            // 
            // txtLOCALIDAD
            // 
            this.txtLOCALIDAD.Enabled = false;
            this.txtLOCALIDAD.Location = new System.Drawing.Point(260, 149);
            this.txtLOCALIDAD.Margin = new System.Windows.Forms.Padding(4);
            this.txtLOCALIDAD.Name = "txtLOCALIDAD";
            this.txtLOCALIDAD.Size = new System.Drawing.Size(212, 22);
            this.txtLOCALIDAD.TabIndex = 28;
            // 
            // btnBUSCAR_PEDIDO
            // 
            this.btnBUSCAR_PEDIDO.Image = global::FactorySys.Properties.Resources.find;
            this.btnBUSCAR_PEDIDO.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBUSCAR_PEDIDO.Location = new System.Drawing.Point(501, 33);
            this.btnBUSCAR_PEDIDO.Margin = new System.Windows.Forms.Padding(4);
            this.btnBUSCAR_PEDIDO.Name = "btnBUSCAR_PEDIDO";
            this.btnBUSCAR_PEDIDO.Size = new System.Drawing.Size(291, 58);
            this.btnBUSCAR_PEDIDO.TabIndex = 32;
            this.btnBUSCAR_PEDIDO.Text = "Buscar Pedido";
            this.btnBUSCAR_PEDIDO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBUSCAR_PEDIDO.UseVisualStyleBackColor = true;
            this.btnBUSCAR_PEDIDO.Click += new System.EventHandler(this.btnBUSCAR_PEDIDO_Click);
            // 
            // txtCLASE
            // 
            this.txtCLASE.Enabled = false;
            this.txtCLASE.Location = new System.Drawing.Point(260, 181);
            this.txtCLASE.Margin = new System.Windows.Forms.Padding(4);
            this.txtCLASE.Name = "txtCLASE";
            this.txtCLASE.Size = new System.Drawing.Size(212, 22);
            this.txtCLASE.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(204, 185);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 17);
            this.label10.TabIndex = 29;
            this.label10.Text = "Clase:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tbTareas);
            this.tabControl1.Location = new System.Drawing.Point(16, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(988, 724);
            this.tabControl1.TabIndex = 58;
            // 
            // tbTareas
            // 
            this.tbTareas.Controls.Add(this.groupBox1);
            this.tbTareas.Location = new System.Drawing.Point(4, 25);
            this.tbTareas.Name = "tbTareas";
            this.tbTareas.Padding = new System.Windows.Forms.Padding(3);
            this.tbTareas.Size = new System.Drawing.Size(980, 695);
            this.tbTareas.TabIndex = 2;
            this.tbTareas.Text = "Tareas";
            this.tbTareas.UseVisualStyleBackColor = true;
            // 
            // dgvLINEA_FABRICACION
            // 
            this.dgvLINEA_FABRICACION.AllowUserToAddRows = false;
            this.dgvLINEA_FABRICACION.AllowUserToDeleteRows = false;
            this.dgvLINEA_FABRICACION.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLINEA_FABRICACION.Location = new System.Drawing.Point(28, 36);
            this.dgvLINEA_FABRICACION.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLINEA_FABRICACION.Name = "dgvLINEA_FABRICACION";
            this.dgvLINEA_FABRICACION.ReadOnly = true;
            this.dgvLINEA_FABRICACION.Size = new System.Drawing.Size(794, 236);
            this.dgvLINEA_FABRICACION.TabIndex = 37;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvLINEA_FABRICACION);
            this.groupBox1.Location = new System.Drawing.Point(68, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(845, 290);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tareas realizadas a la Orden";
            // 
            // frmOF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 807);
            this.Controls.Add(this.btnVERIFICAR);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.btnGUARDAR);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmOF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orden de Fabricación";
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLINEA_INSUMOS)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.gbOF.ResumeLayout(false);
            this.gbOF.PerformLayout();
            this.gbORIGEN.ResumeLayout(false);
            this.gbORIGEN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLINEA_PEDIDO)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tbTareas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLINEA_FABRICACION)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.Button btnVERIFICAR;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvLINEA_INSUMOS;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox gbOF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbESTADO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txtDESCRIPCION;
        private System.Windows.Forms.DateTimePicker dtpFECHA_OF;
        private System.Windows.Forms.TextBox txtCODIGO_OF;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtUSUARIO;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox gbORIGEN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTOTAL;
        private System.Windows.Forms.DataGridView dgvLINEA_PEDIDO;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCOSTO_TOTAL;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNOMBRE;
        private System.Windows.Forms.TextBox txtDIRECCION;
        private System.Windows.Forms.TextBox txtPEDIDO;
        private System.Windows.Forms.TextBox txtCLIENTE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLOCALIDAD;
        private System.Windows.Forms.Button btnBUSCAR_PEDIDO;
        private System.Windows.Forms.TextBox txtCLASE;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnSTOCK;
        private System.Windows.Forms.TabPage tbTareas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvLINEA_FABRICACION;
    }
}