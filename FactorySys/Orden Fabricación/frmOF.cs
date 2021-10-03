using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorySys
{
    public partial class frmOF : Form
    {

        List<Modelo.Insumo> Lista_Insumos;
        Modelo.OrdenFabricacion oOF;
        Modelo.Pedido oPedido;
        Modelo.Usuario oUsuario;
        Controladora.OrdenesFabricacion cOF;
        Controladora.Insumos cInsumos;
        Controladora.Pedidos cPedido;
        string ACCION;
        public frmOF(Modelo.OrdenFabricacion miORDEN, string miACCION, Modelo.Usuario Usuario)
        {
            InitializeComponent();
            cOF = Controladora.OrdenesFabricacion.OBTENER_INSTANCIA();
            cInsumos = Controladora.Insumos.OBTENER_INSTANCIA();
            cPedido = Controladora.Pedidos.OBTENER_INSTANCIA();
            oOF = miORDEN;
            oUsuario = Usuario;
            ACCION = miACCION;
            txtUSUARIO.Text = oUsuario.NOMBRE;
            btnVERIFICAR.Visible = false;
            btnGUARDAR.Visible = true;
            cmbESTADO.DataSource = cOF.LISTAR_ESTADOS();
            cmbESTADO.DisplayMember = "NOMBRE";
            if (ACCION != "A")
            {
                oPedido = oOF.PEDIDO;

                Lista_Insumos = cOF.LISTAR_INSUMOS(oPedido);


                ARMAR_LINEA_INSUMOS();
                ARMAR_LINEA_PEDIDO();
                ARMAR_LINEA_FABRICACION();

                dtpFECHA_OF.Value = oOF.FECHA_ENTREGA;
                COMPLETAR_CAMPOS(oPedido);
                cmbESTADO.SelectedItem = oOF.ESTADO;
                gbORIGEN.Enabled = false;
                txtCODIGO_OF.Text = oOF.CODIGO_OF.ToString(); ;
                txtUSUARIO.Text = oOF.USUARIO.NOMBRE;
                txtDESCRIPCION.Text = oOF.DESCRIPCION;
                if (ACCION == "V")
                {
                    btnGUARDAR.Visible = false;
                    btnVERIFICAR.Visible = true;
                    gbOF.Enabled = false;
                    gbORIGEN.Enabled = false;
                }
                if (oOF.ESTADO.NOMBRE == "FINALIZADA")
                {
                    gbOF.Enabled = false;

                }
            }
        }
        private void ARMAR_LINEA_PEDIDO()
        {
            dgvLINEA_PEDIDO.DataSource = null;
            dgvLINEA_PEDIDO.DataSource = oPedido.LINEA_PEDIDO.ToList();
            dgvLINEA_PEDIDO.Columns[3].Visible = false;
            dgvLINEA_PEDIDO.Columns[5].Visible = false;
        }
        private void ARMAR_LINEA_INSUMOS()
        {
            dgvLINEA_INSUMOS.DataSource = null;
            dgvLINEA_INSUMOS.DataSource = cOF.ARMAR_INSUMOS(Lista_Insumos);
        }
        public void ARMAR_LINEA_FABRICACION()
        {
            dgvLINEA_FABRICACION.DataSource = null;
            dgvLINEA_FABRICACION.DataSource = oOF.LINEA_OF.ToList();
            dgvLINEA_FABRICACION.Columns[3].Width = 350;
            dgvLINEA_FABRICACION.Columns[1].Visible = false;
        }
        private void btnBUSCAR_PEDIDO_Click(object sender, EventArgs e)
        {
            frmBUSCARPEDIDOS abrir = new frmBUSCARPEDIDOS("NADA");
            DialogResult resultado = abrir.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                oPedido = abrir.pedidoSeleccionado;
                if (oPedido.ESTADO == "ASIGNADA")
                {
                    MessageBox.Show("El pedido que seleccionó, ya posee una orden de fabricación asignada.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                COMPLETAR_CAMPOS(oPedido);

                Lista_Insumos = new List<Modelo.Insumo>();
                Lista_Insumos = cOF.LISTAR_INSUMOS(oPedido);

                ARMAR_LINEA_INSUMOS();
                ARMAR_LINEA_PEDIDO();
            }
        }

        private void COMPLETAR_CAMPOS(Modelo.Pedido oPedido)
        {
            txtPEDIDO.Text = oPedido.CODIGO_PEDIDO.ToString();
            txtCLIENTE.Text = oPedido.CODIGO_CLIENTE.ToString();
            txtNOMBRE.Text = oPedido.CLIENTE.NOMBRE;
            txtLOCALIDAD.Text = oPedido.CLIENTE.LOCALIDAD.ToString();
            txtDIRECCION.Text = oPedido.CLIENTE.DIRECCION;
            txtCLASE.Text = oPedido.CLIENTE.CATEGORIA;
            txtCOSTO_TOTAL.Text = oPedido.COSTO_TOTAL.ToString();
            txtTOTAL.Text = oPedido.TOTAL.ToString();
        }
        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            oPedido.ESTADO = "ASIGNADA";
            oOF.DESCRIPCION = txtDESCRIPCION.Text;
            oOF.USUARIO = oUsuario;
            oOF.FECHA_CONFECCION = DateTime.Now.Date;
            oOF.FECHA_ENTREGA = dtpFECHA_OF.Value.Date;
            if (ACCION == "A")
            {
                cmbESTADO.SelectedIndex = 0;
                oOF.ESTADO = (Modelo.Estado)cmbESTADO.SelectedItem;  //una nueva orden de fabricacion con estado confeccionada.
                oOF.PEDIDO = oPedido;
                cPedido.MODIFICAR_PEDIDO(oPedido);
                cOF.AGREGAR_OF(oOF);
            }
            else
            {
                cOF.MODIFICAR_OF(oOF);
            }
            DialogResult = DialogResult.OK;
        }
        private void btnVERIFICAR_Click(object sender, EventArgs e)
        {    
            DialogResult resultado2 = MessageBox.Show("Al verificar la orden, esta será enviada a fábrica y el stock necesario será dado de baja. ¿Desea continua?", "Advertencia", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            switch (resultado2)
            {
                case DialogResult.Yes:
                    if (VERIF_STOCK() == false)
                    {
                        MessageBox.Show("No es posible verificar la Orden, a causa de falta de insumos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (BAJA_STOCK() == false)
                    {
                        MessageBox.Show("Ocurrió un error al realizar la baja del stock.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }                    
                    cmbESTADO.SelectedIndex = 1;
                    oOF.ESTADO = (Modelo.Estado)cmbESTADO.SelectedItem;
                    cOF.MODIFICAR_OF(oOF);
                    MessageBox.Show("¡Orden de Fabricacion verificada con éxito!","Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    break;
                case DialogResult.No:
                    return;
                case DialogResult.Cancel:
                    return;
                default:
                    break;
            }
        }
        private void btnSTOCK_Click(object sender, EventArgs e)
        {
            frmSTOCK abrir = frmSTOCK.OBTENER_INSTANCIA();
            abrir.Show();
        }
        private bool VERIF_STOCK()
        {
            bool rest = true;
            foreach (Modelo.Insumo item in Lista_Insumos.ToList())
            {
                foreach (var oInsumo in cInsumos.LISTAR())
                {
                    if (item.CODIGO_INSUMO == oInsumo.CODIGO_INSUMO)
                    {
                        if (item.CANTIDAD >= oInsumo.CANTIDAD)
                        {
                            rest = false;
                        }
                    }
                }
            }
            return rest;
        }
        private bool BAJA_STOCK()
        {
            try
            {
                foreach (Modelo.Insumo item in Lista_Insumos.ToList())
                {
                    foreach (Modelo.Insumo oInsumo in cInsumos.LISTAR())
                    {
                        if (item.CODIGO_INSUMO == oInsumo.CODIGO_INSUMO)
                        {
                            oInsumo.CANTIDAD = oInsumo.CANTIDAD - item.CANTIDAD;
                            cInsumos.MODIFICAR_INSUMO(oInsumo);
                        }
                    }
                }
                return true;
            }

            catch (Exception)
            {
                return false;
            }        
        }
    }
}

