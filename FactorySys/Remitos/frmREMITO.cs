using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorySys.Remitos
{
    public partial class frmREMITO : Form
    {
        Modelo.OrdenCompra oOrden;
        Modelo.Insumo oInsumo;
        Modelo.LineaRemito oLineaRemito;
        Modelo.Remito oRemito;

        List<Modelo.LineaRemito> Lineas_Remito; //solucion error >>modificar>>cancelar
        Controladora.Remitos cRemito;
        Controladora.OrdenesCompra cOrden;
        Controladora.Insumos cInsumos;

        string ACCION;
        decimal CANTIDAD;
        public frmREMITO(Modelo.Remito miREMITO, string miACCION)
        {
            InitializeComponent();
            cRemito = Controladora.Remitos.OBTENER_INSTANCIA();
            cInsumos = Controladora.Insumos.OBTENER_INSTANCIA();
            cOrden = Controladora.OrdenesCompra.OBTENER_INSTANCIA();
            ACCION = miACCION;
            oRemito = miREMITO;
            Lineas_Remito = miREMITO.LINEA_REMITO.ToList(); //solucion error >>modificar>>cancelar
            cmbENTREGA.DataSource = cRemito.LISTAR_ENTREGA();
            cmbENTREGA.DisplayMember = "NOMBRE";
            //dgvLINEA_REMITO.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(147, 192, 183); //intercambiar colores     
            if (ACCION != "A")
            {
                oOrden = oRemito.ORDEN;
                txtTOTAL.Text = oRemito.TOTAL.ToString();
                btnOC.Enabled = false;
                txtESTADO.Text = oRemito.ORDEN.ESTADO;
                txtPROVEEDOR.Text = oRemito.ORDEN.PROVEEDOR.NOMBRE;
                dtpFECHAO.Value = oRemito.ORDEN.FECHA_EMISION;
                txtCODIGOOC.Text = oRemito.ORDEN.CODIGO_ORDEN.ToString();
                dtpFECHAE.Value = oRemito.FECHA_ENTREGA;
                ARMAR_GRILLA();
            }
        }
        private void ARMAR_GRILLA()
        {
            dgvLINEA_REMITO.DataSource = null;
            dgvLINEA_REMITO.DataSource = oRemito.LINEA_REMITO.ToList();
            //Oculto lineas que no interesan
            dgvLINEA_REMITO.Columns[3].Visible = false;
            dgvLINEA_REMITO.Columns[5].Visible = false;
            dgvLINEA_REMITO.Columns[6].Visible = false;
            dgvLINEA_REMITO.Columns[7].Visible = false;
        }
        private void btnOC_Click(object sender, EventArgs e)
        {
            Orden_de_compra.frmBUSCAROC abrir = new Orden_de_compra.frmBUSCAROC("UNO");
            DialogResult resultado = abrir.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                oRemito.LINEA_REMITO.Clear();
                oOrden = abrir.oOrden;
                if (oOrden.VERIFICADO == false)
                {
                    MessageBox.Show("No se permite cargar una Orden de Compra que no está verificada.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                if (oOrden.ESTADO == "Entregado")
                {
                    MessageBox.Show("La Orden de Comppra seleccionada ya fue recibida. Pruebe seleccionando otra.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                txtCODIGOOC.Text = oOrden.CODIGO_ORDEN.ToString();
                txtPROVEEDOR.Text = oOrden.PROVEEDOR.NOMBRE;
                txtESTADO.Text = oOrden.ESTADO;
                txtTOTAL.Text = Convert.ToString(oOrden.TOTAL);
                dtpFECHAO.Value = oOrden.FECHA_EMISION;


                foreach (var item in oOrden.LINEAOC)
                {
                    oLineaRemito = new Modelo.LineaRemito();
                    oLineaRemito.INSUMO = item.INSUMO;
                    oLineaRemito.CANTIDAD = item.CANTIDAD;
                    oLineaRemito.PRECIO = item.PRECIO;
                    oLineaRemito.ENTREGA = item.ENTREGA;
                    oLineaRemito.CODIGO_INSUMO = item.CODIGO_INSUMO;
                    oRemito.LINEA_REMITO.Add(oLineaRemito);
                }
                ARMAR_GRILLA();
            }
        }
        private void dgvLINEA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Busca el insumo.
            oInsumo = Controladora.Insumos.OBTENER_INSTANCIA().BUSCAR_INSUMO(Convert.ToInt32(dgvLINEA_REMITO.CurrentRow.Cells[3].Value));

            txtINSUMO.Text = Convert.ToString(dgvLINEA_REMITO.CurrentRow.Cells[4].Value);
            txtCANTIDAD.Text = Convert.ToString(dgvLINEA_REMITO.CurrentRow.Cells[1].Value);
            txtPRECIO.Text = Convert.ToString(dgvLINEA_REMITO.CurrentRow.Cells[2].Value);
            CANTIDAD = Convert.ToDecimal(txtCANTIDAD.Text);
        }
        private void btnINSUMO_Click(object sender, EventArgs e)
        {
            Insumos.frmBUSCARINSUMO abrir = new Insumos.frmBUSCARINSUMO("UNO");
            DialogResult resultado = abrir.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                oInsumo = abrir.insumoSeleccionado;
                txtINSUMO.Text = oInsumo.NOMBRE_INSUMO;
                txtPRECIO.Text = oInsumo.PRECIO.ToString();
            }
        }
        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            if (oRemito == null)
            {
                return;
            }
            if (string.IsNullOrEmpty(txtCANTIDAD.Text) || string.IsNullOrEmpty(txtPRECIO.Text) || string.IsNullOrEmpty(txtINSUMO.Text))
            {
                MessageBox.Show("Campos invalidos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Int32 candidad = 0;
            if (!Int32.TryParse(txtCANTIDAD.Text, out candidad))
            {
                MessageBox.Show("Debes ingresar correctamente la cantidad");
                return;
            }
            decimal precio = 0;
            if (!decimal.TryParse(txtPRECIO.Text, out precio))
            {
                MessageBox.Show("Debes ingresar correctamente el precio");
                return;
            }

            //cargo las lineas del remito
            oLineaRemito = new Modelo.LineaRemito();
            oLineaRemito.INSUMO = oInsumo;
            oLineaRemito.CANTIDAD = Convert.ToInt32(txtCANTIDAD.Text);
            oLineaRemito.PRECIO = Convert.ToDecimal(txtPRECIO.Text);
            oLineaRemito.CODIGO_INSUMO = oInsumo.CODIGO;
            oLineaRemito.ENTREGA = (Modelo.Entrega)cmbENTREGA.SelectedItem;           
            

            ////agrego la linea de remito
            oRemito.LINEA_REMITO.Add(oLineaRemito);
           
            txtTOTAL.Text = oRemito.TOTAL.ToString();
            ARMAR_GRILLA();
        }
        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            if (dgvLINEA_REMITO.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una linea del remito a eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            oLineaRemito = (Modelo.LineaRemito)dgvLINEA_REMITO.CurrentRow.DataBoundItem;
            //actualizo el txtTotal
            oRemito.LINEA_REMITO.Remove(oLineaRemito);
            txtTOTAL.Text = oRemito.TOTAL.ToString();  
            ARMAR_GRILLA();
        }
        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            if (oOrden == null)
            {
                MessageBox.Show("No puede generar un Remito sin selccionar su Orden de Compra. Intente seleccionando una.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (dgvLINEA_REMITO.Rows.Count == 0)
            {
                MessageBox.Show("No puede generar un Remito sin ningun Detalle. Intente agregando alguno/s", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            oRemito.FECHA_ENTREGA = dtpFECHAO.Value;
            oRemito.ORDEN = oOrden;
            if (ACCION == "A")
            {
                cRemito.AGREGAR_REMITO(oRemito);
                oOrden.ESTADO = "Entregado";
                foreach (var Linea_Remito in oRemito.LINEA_REMITO.ToList())
                {
                    foreach (var Linea_Orden in oOrden.LINEAOC.ToList())
                    {
                        if (Linea_Orden.INSUMO == Linea_Remito.INSUMO)
                        {
                            Linea_Orden.ENTREGA = Linea_Remito.ENTREGA;
                        }
                    }
                }
                cOrden.MODIFICAR_ORDENCOMPRA(oOrden,new HashSet<Modelo.LineaOrdenCompra>());
            }
            if (ACCION == "M")
            {
                cRemito.MODIFICAR_REMITO(oRemito);
            }
            //actualizo el stock
            foreach (var oLinea in oRemito.LINEA_REMITO.ToList())
            {
                foreach (Modelo.Insumo oInsumo in cInsumos.LISTAR())
                {
                    if (oLinea.INSUMO == oInsumo)
                    {
                        if (oLinea.ENTREGA.NOMBRE == "TOTAL" || oLinea.ENTREGA.NOMBRE == "PARCIAL")
                        {
                            oInsumo.CANTIDAD = oLinea.CANTIDAD + oInsumo.CANTIDAD;
                            cInsumos.MODIFICAR_INSUMO(oInsumo);
                        }                  
                    }
                }
            }
            this.DialogResult = DialogResult.OK;
        }
        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            oRemito.LINEA_REMITO = Lineas_Remito; //solucion error >>modificar>>cancelar
            this.DialogResult = DialogResult.Cancel;
        }
        private void btnREFRESCAR_Click(object sender, EventArgs e)
        {
            if (oInsumo == null)
            {
                return;
            }
            Modelo.LineaRemito Nueva_Linea = new Modelo.LineaRemito();
            Nueva_Linea = (Modelo.LineaRemito)dgvLINEA_REMITO.CurrentRow.DataBoundItem;
            ENTREGA();
            Nueva_Linea.PRECIO = Convert.ToDecimal(txtPRECIO.Text);
            Nueva_Linea.CANTIDAD = Convert.ToInt32(txtCANTIDAD.Text);   
            Nueva_Linea.ENTREGA = (Modelo.Entrega)cmbENTREGA.SelectedItem;
            //Nueva_Linea.
            oRemito.LINEA_REMITO.Remove((Modelo.LineaRemito)dgvLINEA_REMITO.CurrentRow.DataBoundItem);
            oRemito.LINEA_REMITO.Add(Nueva_Linea);     
            txtTOTAL.Text = oRemito.TOTAL.ToString();
            ARMAR_GRILLA();
        }
        private void ENTREGA()
        {
            if (Convert.ToInt32(txtCANTIDAD.Text) < CANTIDAD)
            {
                cmbENTREGA.SelectedIndex = 1;
            }
            if (Convert.ToInt32(txtCANTIDAD.Text) >= CANTIDAD)
            {
                cmbENTREGA.SelectedIndex = 2;
            }
            if (Convert.ToInt32(txtCANTIDAD.Text) == 0)
            {
                cmbENTREGA.SelectedIndex = 3;
            }
        }
    }

}
